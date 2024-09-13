using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BXM308_Assignment.Model
{
    public class RoomSeatContainer
    {
        public string TimeRefId { get; set; }
        public string RefId { get; set; }
        public ObservableCollection<RoomSeat> RoomSeatList;
    }
}
