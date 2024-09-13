using BXM308_Assignment.Layout;
using BXM308_Assignment.Model;
using BXM308_Assignment.PageViewModel;
using BXM308_Assignment.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Globalization;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace BXM308_Assignment.Converter
{
    public class MovieCollectionViewHeightConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is ObservableCollection<MovieViewModel> movieList)
            {
                decimal count = movieList.Count / 3;
                count = Math.Ceiling(count);

                var ppi = DeviceDisplay.MainDisplayInfo.Density;
                if (ppi >= 2.75 && ppi <= 2.9)
                    return count * 255;
                else
                    return count * 245;

            }
            return 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
