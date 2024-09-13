using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace BXM308_Assignment.Converter
{
    public class TicketTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value.ToString())
            {
                case "Claimed":
                    return "Wait for show";
                case "Active":
                    return "Claim";
                case "OnShowing":
                    return "Claim Now";
                case "Expired":
                    return "Expired";
                case "WaitingForReview":
                    return "Write a review";
            }
            return "Claim";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
