using SkiaSharp.Views.Forms;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace BXM308_Assignment.CustomView
{
    public class StarView : SKCanvasView
    {
        public static readonly BindableProperty RatingProperty =
           BindableProperty.Create(nameof(Rating), typeof(double), typeof(StarView), 0.0, propertyChanged: OnPropertyChanged);
        public double Rating
        {
            get { return (double)GetValue(RatingProperty); }
            set { SetValue(RatingProperty, value); }
        }
        public static readonly BindableProperty FilltColorProperty =
         BindableProperty.Create(nameof(FillColors), typeof(string), typeof(StarView), "#FFFF00", propertyChanged: OnPropertyChanged);
        public string FillColors
        {
            get { return (string)GetValue(FilltColorProperty); }
            set { SetValue(FilltColorProperty, value); }
        }
        public static readonly BindableProperty StrokeColorProperty =
          BindableProperty.Create(nameof(StrokeColor), typeof(string), typeof(StarView), "#000000", propertyChanged: OnPropertyChanged);
        public string StrokeColor
        {
            get { return (string)GetValue(StrokeColorProperty); }
            set { SetValue(StrokeColorProperty, value); }
        }

        public static readonly BindableProperty EmptyColorProperty =
          BindableProperty.Create(nameof(EmptyColor), typeof(string), typeof(StarView), "#000000", propertyChanged: OnPropertyChanged);
        public string EmptyColor
        {
            get { return (string)GetValue(EmptyColorProperty); }
            set { SetValue(EmptyColorProperty, value); }
        }
        private static void OnPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is StarView starView)
            {
                starView.InvalidateSurface();
            }
        }


        private static SKPath starPath;
        protected override void OnPaintSurface(SKPaintSurfaceEventArgs e)
        {
            base.OnPaintSurface(e);

            SKImageInfo info = e.Info;
            SKSurface surface = e.Surface;
            SKCanvas canvas = surface.Canvas;

            canvas.Clear(SKColors.Transparent);

            //Only Initial Once
            if (starPath == null)
            {
                starPath = new SKPath();
                float centerX = info.Width / 2f;
                float centerY = info.Height / 2f;
                float outerRadius = Math.Min(info.Width, info.Height) / 2f * 0.8f; //Star Size
                float innerRadius = outerRadius * 0.382f;
                for (int i = 0; i < 10; i++)
                {
                    float radius = (i % 2 == 0) ? outerRadius : innerRadius;
                    float angle = ((i * 2 + 1) * (float)Math.PI / 10) + (float)Math.PI / 5; //Star Angle
                    float x = centerX + radius * (float)Math.Cos(angle);
                    float y = centerY + radius * (float)Math.Sin(angle);

                    if (i == 0)
                        starPath.MoveTo(x, y);
                    else
                        starPath.LineTo(x, y);
                }
                starPath.Close();
            }

            using (SKPaint paint = new SKPaint())
            {
                var position = CorrectPositionPoint(Rating);
                if (Rating > 0)
                {
                    SKPoint startPoint = new SKPoint(0, 0); // 渐变的起点坐标
                    SKPoint endPoint = new SKPoint(info.Width, 0); // 渐变的终点坐标
                    SKColor[] colors = new SKColor[] { Color.FromHex(FillColors).ToSKColor(), Color.Transparent.ToSKColor() }; // 渐变的颜色
                    float[] colorPos = new float[] { position, position }; // 渐变颜色的位置，0 表示起点，1 表示终点

                    SKShader shader = SKShader.CreateLinearGradient(startPoint, endPoint, colors, colorPos, SKShaderTileMode.Clamp);
                    paint.Shader = shader;
                }
                else
                    paint.Color = Color.Transparent.ToSKColor();

                paint.IsAntialias = true;

                //Draw Shadow
                using (SKPaint shadowPaint = new SKPaint())
                {
                    shadowPaint.Color = Rating > 0 ? Color.FromHex(StrokeColor).ToSKColor() : Color.FromHex(EmptyColor).ToSKColor(); ; // Shadow Color
                    shadowPaint.Style = SKPaintStyle.Fill;
                    shadowPaint.IsAntialias = true;
                    shadowPaint.MaskFilter = SKMaskFilter.CreateBlur(SKBlurStyle.Outer, 4); // Shadow Blur

                    //Set Shadow postion
                    starPath.Offset(1, 1);
                    canvas.DrawPath(starPath, shadowPaint);
                }
                //Reset star postion
                starPath.Offset(-1,-1 );
                if (Rating > 0)
                    // Fill in star color
                    canvas.DrawPath(starPath, paint);
                //Star Border/Stroke Color (Empty Star)
                using (SKPaint borderPaint = new SKPaint())
                {
                    borderPaint.Color = Rating > 0 ? Color.FromHex(StrokeColor).ToSKColor() : Color.FromHex(EmptyColor).ToSKColor(); ;
                    borderPaint.IsStroke = true;
                    borderPaint.StrokeWidth = 2;

                    canvas.DrawPath(starPath, borderPaint);
                }
            }
        }
        private float CorrectPositionPoint(double rating)
        {
            if (rating == 0)
                return 0.0f;
            else if (rating == 1)
                return 1.0f;
            else
            {
                float position = (float)(0.30 + rating * 0.40);
                return position;
            }
        }
    }

}
