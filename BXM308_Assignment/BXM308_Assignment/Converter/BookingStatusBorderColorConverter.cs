using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace BXM308_Assignment.Converter
{
    public class BookingStatusBorderColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value.ToString())
            {
                case "Unavailable":
                case "false":
                case "Select a seat >":
                    return "#337a7a7a";
                case "Selected":
                case "Review & Payment >":
                case "true":
                    return "#4Dff6400";
                case "Available":
                default:
                    return "#4DB3B3B3";
            }
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }
}
