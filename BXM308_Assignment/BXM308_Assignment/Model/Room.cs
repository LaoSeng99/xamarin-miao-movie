using System;
using System.Collections.Generic;
using System.Text;

namespace BXM308_Assignment.Model
{
    public class Room
    {
        public string Id { get; set; } //For Relationship
        public string RoomId { get; set; } // Firebase Key
        public string Date { get; set; }
        public string CreateTime { get; set; }

        public List<RoomTime> TimeShow { get; set; }


    }
}
