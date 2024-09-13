using BXM308_Assignment.Model;
using BXM308_Assignment.PageViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Internals;

namespace BXM308_Assignment.ViewModels
{
    public class BookingPageViewModel : BaseViewModel
    {
        public BookingPageViewModel(TicketVM ticket, RoomSeatContainerVM selected, RoomTime room)
        {
            Ticket = ticket;
            SelectedTime = selected;
            RoomTime = room;
        }
        protected override async void OnLoadCommandExecute()
        { }

        public async Task PaymentComplete(bool isSuccess)
        {
            if (isSuccess)
            {

                string userId = await AppPreferences.GetString("UserId");
                SelectedTime.SeatLists.Where(c => c.IsLabel == false && c.Status == "Selected")
                                      .ForEach(c =>
                                      {
                                          c.TicketId = Ticket.Id;
                                          c.Status = "Reserved";
                                          c.ReserverUserRefId = userId;
                                      });

                var isFull = SelectedTime.SeatLists.Where(c => c.IsLabel == false).All(seat => seat.Status == "Selected" || seat.Status == "Reserved");  
                RoomTime.IsFull = isFull;
                RoomTime.Status = isFull ? "Unavailable" : "Available";

                Ticket.IsPaid = true;
                Ticket.Status = "Active";
                Ticket.PaymentTime = DateTime.UtcNow.AddHours(8);

                Task UpdateSeat = Firebase.Firebase.UpdateSeat(SelectedTime);
                Task UpdateRoom = Firebase.Firebase.UpdateRoomTime(RoomTime);
                Task CreateTicket = Firebase.Firebase.AddNewTicket(Ticket);

                await Task.WhenAll(UpdateSeat, UpdateRoom, CreateTicket);
            }
            Success = isSuccess;
            IsLoading = false;
            IsImageShow = true;
            ImageLink = isSuccess ? "PaymentSuccess" : "PaymentFailed";
            StatusText = isSuccess ? "Thanks for the payment." : "Something wrong, please try again";
            PaymentStatusText = isSuccess ? "Get tickets" : "Try Again";
            PaymentStatusColor = isSuccess ? "#ff6400" : "#999c9386";
        }
        public void ResetProperty()
        {
            PaymentStatusText = "";
            PaymentStatusColor = "#999c9386";
            StatusText = "Redirecting to payment...";
            ImageLink = "";
            IsLoading = true;
            IsImageShow = false;
        }

        public bool Success;
        private string paymentStatusText = "";
        public string PaymentStatusText
        {
            get => paymentStatusText;
            set => SetProperty(ref paymentStatusText, value);
        }
        private string paymentStatusColor = "#999c9386";
        public string PaymentStatusColor
        {
            get => paymentStatusColor;
            set => SetProperty(ref paymentStatusColor, value);
        }

        private bool isLoading = true;
        public bool IsLoading
        {
            get => isLoading;
            set => SetProperty(ref isLoading, value);
        }
        private bool isImageShow = false;
        public bool IsImageShow
        {
            get => isImageShow;
            set => SetProperty(ref isImageShow, value);
        }
        private string imageLink = "";
        public string ImageLink
        {
            get => imageLink;
            set => SetProperty(ref imageLink, value);
        }
        private string statusText = "Redirecting to payment...";
        public string StatusText
        {
            get => statusText;
            set => SetProperty(ref statusText, value);
        }
        private TicketVM ticket;
        public TicketVM Ticket
        {
            get => ticket;
            set => SetProperty(ref ticket, value);
        }
        public RoomSeatContainerVM SelectedTime;
        public RoomTime RoomTime;
    }
}
