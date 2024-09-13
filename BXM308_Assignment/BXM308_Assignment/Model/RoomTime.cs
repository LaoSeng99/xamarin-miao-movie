using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace BXM308_Assignment.Model
{
    public class RoomTime : BaseClassVM
    {
        public string RefId { get; set; }
        public string Date { get; set; }
        public string RoomId { get; set; }
        public string Time { get; set; } //13：00， 16：00 // 过后Convert到 PM, AM
        public string MovieId { get; set; }
        bool isBusy;
        public bool IsBusy
        {
            get { return isBusy; }
            set { SetProperty(ref isBusy, value); }
        }
        string status = "";
        public string Status
        {
            get
            {
                if (status == "")
                    return IsFull ? "Unavailable" : "Available";
                return status;
            }
            set => SetProperty(ref status, value);
        }
        public bool IsFull { get; set; }

    }
}
