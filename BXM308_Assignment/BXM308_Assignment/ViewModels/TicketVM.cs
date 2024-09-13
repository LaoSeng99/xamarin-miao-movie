using BXM308_Assignment.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace BXM308_Assignment.ViewModels
{
    public class TicketVM : Ticket
    {
        public string AmountDisplay { get => TotalAmount.ToString("RM #,##0.00", new CultureInfo("ms-MY")); }
        public string TotalTax { get => (TotalAmount * 0.06).ToString("RM #,##0.00", new CultureInfo("ms-MY")); }
        public string SubTotal { get => (TotalAmount * 0.94).ToString("RM #,##0.00", new CultureInfo("ms-MY")); }
        public string DisplayRoomId
        {
            get
            {
                if (RoomId != null)
                {
                    var stringArray = RoomId.Split('-');
                    return $"{stringArray[0]} {stringArray[1].TrimStart('0')}";
                }


                return "";
            }
        }
        public string DurationTime
        {
            get
            {
                if (MovieDuration != null)
                    return $"{MovieDuration.Hours}h {MovieDuration.Minutes}m";

                return "";
            }
        }
        public List<string> CodeList
        {
            get
            {
                if (ReservationCode != null)
                    return ReservationCode.Replace(" ", "").Split(',').ToList();
                return null;
            }
        }
    }
}
