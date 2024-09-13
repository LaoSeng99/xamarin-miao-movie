using BXM308_Assignment.PageViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BXM308_Assignment.ViewModels
{
    public class ClaimTicketPageViewModel : BaseViewModel

    {
        public ClaimTicketPageViewModel(TicketVM ticket)
        {
            Ticket = ticket;
            ClaimStatus = ticket.Status == "Claimed" ? "Claimed" : "Complete";
        }
        protected override void OnLoadCommandExecute()
        {

        }
        private TicketVM ticket;
        public TicketVM Ticket
        {
            get => ticket;
            set => SetProperty(ref ticket, value);
        }
        private string claimStatus;
        public string ClaimStatus
        {
            get => claimStatus; set => SetProperty(ref claimStatus, value);
        }
    }
}
