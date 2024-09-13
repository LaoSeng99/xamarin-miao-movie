using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace BXM308_Assignment.Model
{
    public class DateClass :BaseClassVM
    {
        public string Id { get; set; }
        public string Day { get; set; }
        public string Month { get; set; }
        public bool IsAvailable { get; set; }
        bool isBusy = false;
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
                    return IsAvailable ? "Available" : "Unavailable";
                return status;
            }
            set => SetProperty(ref status, value);
        }
    }
}
