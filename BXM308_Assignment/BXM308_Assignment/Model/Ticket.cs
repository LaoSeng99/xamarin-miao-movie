using System;
using System.Collections.Generic;
using System.Text;

namespace BXM308_Assignment.Model
{
    public class Ticket
    {
        public string Id { get; set; } //For Relationship
        public string TicketId { get; set; } // Firebase Key
        public DateTime CreatedTime { get; set; }
        public DateTime PaymentTime { get; set; }
        public string ReservationCode { get; set; }// Split SeatCode With ,
        public double TotalAmount { get; set; }
        public int ReservaSeatNumber { get; set; }
        public bool IsPaid { get; set; } = false;
        public string Status { get; set; } //Pending Payment,Expired, Active,Wait Review, Reviewed
        public string UserId { get; set; } //User Firebase Key
        public string RoomTimeRefId { get; set; }// RoomTime Firebase Key
        public string Date { get; set; } // 23-09-2023|10:45 AM dd-MMM-yyyy hh:mm tt
        public string Time { get; set; } // 23-09-2023|10:45 AM dd-MMM-yyyy hh:mm tt
        public string MovieId { get; set; } //Movie ID
        public string MoviePoster { get; set; } //Movie ID
        public string MovieTitle { get; set; } //Movie ID
        public TimeSpan MovieDuration { get; set; } //Movie ID
        public string RoomId { get; set; }
    }
}
