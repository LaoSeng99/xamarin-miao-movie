using System;
using System.Collections.Generic;
using System.Text;

namespace BXM308_Assignment.Model
{
    public class Payment
    {
        public string Id { get; set; } //For Relationship    
        public string PaymentId { get; set; } // Firebase Key
        public double Amount { get; set; }
        public string TimeStamp { get; set; }
        public string DiscountCode { get; set; }
        public string PaymentMethod { get; set; }
        public string TransactionRef { get; set; }
        public string ReservationId { get; set; }
    }
}
