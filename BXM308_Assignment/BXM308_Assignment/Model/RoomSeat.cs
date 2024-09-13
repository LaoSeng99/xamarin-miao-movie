using System;
using System.Collections.Generic;
using System.Text;

namespace BXM308_Assignment.Model
{
    public class RoomSeat : BaseClassVM
    {

        public string Code { get; set; }
        public string TicketId { get; set; }

        public string status;
        public string Status
        {
            get => status;
            set => SetProperty(ref status, value);
        }
        public string ReserverUserRefId { get; set; }
        public int InGridColumn { get; set; }
        public int InGridRow { get; set; }
        public bool IsLabel { get; set; }
    }
}
