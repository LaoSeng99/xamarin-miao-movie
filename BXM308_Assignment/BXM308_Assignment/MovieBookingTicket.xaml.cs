using BXM308_Assignment.Model;
using BXM308_Assignment.PageViewModel;
using BXM308_Assignment.Popup;
using BXM308_Assignment.ViewModels;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BXM308_Assignment
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MovieBookingTicket : ContentPage
    {
        public MovieBookingTicket(MovieViewModel movie)
        {
            InitializeComponent();
            MovieBookingPageViewModel = new MovieBookingPageViewModel(movie);
            this.BindingContext = MovieBookingPageViewModel;
            //MessagingCenter.Subscribe<App>((App)Application.Current, "NoMovieTime", async (sender) =>
            //{
            //    await DisplayAlert("This Movie Is Unavailable now", "Apologies for the inconvenience", "Quit");
            //    await ClosePage();
            //});
        }
        protected async override void OnAppearing()
        {
            if (BindingContext is BaseViewModel viewModel)
                viewModel.LoadCommand.Execute(null);

            await Task.Delay(200);
            await PageContent.FadeTo(1, 200, Easing.Linear);
        }
        protected override bool OnBackButtonPressed()
        {
            if (BookingReviewPopup.IsRedirecting)
                return true;

            if (PopupNavigation.Instance.PopupStack.Count > 0)
            {
                _ = PopupNavigation.Instance.PopAsync();
                return true;
            }
            _ = ClosePage();
            return true;
        }

        //========== Navigate Page ===============
        private void Nav_ClosePage(object sender, EventArgs e)
        {
            _ = ClosePage();
        }
        //========== Function Method ===========
        private async void SelectedDate_Clicked(object sender, EventArgs e)
        {

            //For double clicked check
            if (IsClicked)
                return;
            IsClicked = true;
            //Main Function

            var frame = sender as Frame;
            var tapGesture = frame.GestureRecognizers[0] as TapGestureRecognizer;

            var isAvailable = tapGesture.AutomationId.ToString();
            if (isAvailable == "Unavailable")
            {
                IsClicked = false;
                return;
            }

            FrameClickedAnimation(frame);

            var dateId = tapGesture.CommandParameter.ToString();
            await MovieBookingPageViewModel.UpdateSelectedDateTime(dateId);

            await Task.Delay(250);
            IsClicked = false;
        }
        private async void SelectedTime_Clicked(object sender, EventArgs e)
        {

            //For double clicked check
            if (IsClicked)
                return;
            IsClicked = true;
            //Main Function

            var frame = sender as Frame;
            var tapGesture = frame.GestureRecognizers[0] as TapGestureRecognizer;

            var isFull = tapGesture.AutomationId.ToString();
            if (isFull == "true")
            {
                IsClicked = false;
                return;
            }

            FrameClickedAnimation(frame);

            var time = tapGesture.CommandParameter.ToString();
            await MovieBookingPageViewModel.UpdateSelectedTimeSeat(time);

            await Task.Delay(250);
            IsClicked = false;
        }
        private async void SelectedSeat_Clicked(object sender, EventArgs e)
        {

            //For double clicked check
            if (IsClicked)
                return;
            IsClicked = true;
            //Main Function

            var frame = sender as Frame;
            var tapGesture = frame.GestureRecognizers[0] as TapGestureRecognizer;

            var isAvailable = tapGesture.AutomationId.ToString();
            if (isAvailable == "Reserved")
            {
                IsClicked = false;
                return;
            }

            FrameClickedAnimation(frame);

            var seatCode = tapGesture.CommandParameter.ToString();
            MovieBookingPageViewModel.UpdateSelectedSeat(seatCode);

            await Task.Delay(150);
            IsClicked = false;
        }
        private async void ClearAllSelectedSeat_Clicked(object sender, EventArgs e)
        {
            //For double clicked check
            if (IsClicked)
                return;
            IsClicked = true;
            //Main Function

            MovieBookingPageViewModel.ClearAllSelectedSeat();

            await Task.Delay(150);
            IsClicked = false;
        }
        private async Task ClosePage()
        {
            if (IsClicked)
                return;
            IsClicked = true;

            _ = PageContent.FadeTo(0, 100, Easing.Linear);
            _ = PageContent.TranslateTo(1800, 0, 1000, Easing.Linear);
            await Task.Delay(250);
            await PopupNavigation.Instance.PushAsync(BookingCloseTransitionPopup);
            await Navigation.PopAsync();

            IsClicked = false;
        }
        private async Task AdjustSeatViewToCenter()
        {
            double targetX = (SeatView.ContentSize.Width - SeatView.Width) / 2;
            await SeatView.ScrollToAsync(targetX, 0, true);
        }
        private async void FrameClickedAnimation(Frame frame)
        {
            await frame.ScaleTo(0.90, 45, Easing.Linear);
            _ = frame.ScaleTo(1.1, 45, Easing.Linear);
            _ = frame.ScaleTo(1, 45, Easing.Linear);
        }
        private async void ScrollToBottom(object sender, ScrolledEventArgs e)
        {
            if (firstScroll)
                return;
            var scrollView = sender as ScrollView;
            if (scrollView.ScrollY > 85)
            {
                await AdjustSeatViewToCenter();
                firstScroll = true;
            }

        }

        //========== Object/Bool Area =============

        public MovieBookingPageViewModel MovieBookingPageViewModel;
        private BookingCloseTransitionPopup BookingCloseTransitionPopup = new BookingCloseTransitionPopup(400);
        private bool IsClicked = false;
        private bool firstScroll = false;
        public static bool IsBookingToLogin = false;
        private async void ReviewPayment_Clicked(object sender, EventArgs e)
        {//For double clicked check
            if (IsClicked)
                return;
            IsClicked = true;
            //Main Function

            var checkLogin = await AppPreferences.GetString("UserId");
            if (checkLogin == null)
            {
                var toSignIn = await DisplayAlert("Please Sign In", "Sign in to continue", "Login", "Cancel");
                if (toSignIn)
                {
                    IsBookingToLogin = true;
                    await PopupNavigation.Instance.PushAsync(new BookingTransitionPopup(400));
                    await Navigation.PushAsync(new UserLoginPage(), false);
                }
                IsClicked = false;
                return;
            }

            TicketVM ticket = await MovieBookingPageViewModel.GenerateTicket();
            RoomTime roomTime = MovieBookingPageViewModel.GetSelectedTimeRoom();
            RoomSeatContainerVM seat = MovieBookingPageViewModel.GetSelectedSeat();
            await PopupNavigation.Instance.PushAsync(new BookingReviewPopup(ticket, seat, roomTime));

            await Task.Delay(250);
            IsClicked = false;

        }


    }
}