using BXM308_Assignment.Model;
using BXM308_Assignment.PageViewModel;
using BXM308_Assignment.Popup;
using BXM308_Assignment.ViewModels;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BXM308_Assignment
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MovieDetailPage : ContentPage
    {
        public MovieDetailPage(MovieViewModel movie, bool isBooking)
        {
            IsBooking = isBooking;
            InitializeComponent();
            MovieDetailPageViewModel = new MovieDetailPageViewModel(movie);
            this.BindingContext = MovieDetailPageViewModel;
            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = movie.TrailerLink;
            TrailerLink.Source = htmlSource;

        }
        protected async override void OnAppearing()
        {
            if (BindingContext is BaseViewModel viewModel)
                viewModel.LoadCommand.Execute(null);

            await Task.Delay(200);
            await PageContent.FadeTo(1, 200, Easing.Linear);
         
            
            //If entry with ticket icon, Redirect to bookinig ticket page
            if (IsBooking)
            {
                await Task.Delay(250);
                await PopupNavigation.Instance.PushAsync(new BookingTransitionPopup(400));
                await Navigation.PushAsync(new MovieBookingTicket(MovieDetailPageViewModel.Movie), false);

                IsBooking = false;
            }
            await Task.Delay(800);
            await TrailerLink.FadeTo(1, 200, Easing.Linear);
        }
        protected override bool OnBackButtonPressed()
        {
            if (IsBooking)
                return true;

            _ = ClosePage();
            return true;
        }

        //========== Navigate Page ===============
        private async void Nav_ClosePage(object sender, EventArgs e)
        {
            if (IsClicked || IsBooking)
                return;
            IsClicked = true;

            _ = ClosePage();

            await Task.Delay(250);
            IsClicked = false;
        }
        private async void Nav_BookingTicketPage(object sender, EventArgs e)
        {
            if (IsClicked || IsBooking)
                return;
            IsClicked = true;

            await PopupNavigation.Instance.PushAsync(new BookingTransitionPopup(400));
            await Navigation.PushAsync(new MovieBookingTicket(MovieDetailPageViewModel.Movie), false);

            await Task.Delay(250);
            IsClicked = false;
        }
        private async void Popup_PhotoView(object sender, EventArgs e)
        {
            if (IsClicked || IsBooking)
                return;
            IsClicked = true;

            var stack = sender as StackLayout;
            var tapGesture = stack.GestureRecognizers[0] as TapGestureRecognizer;
            var imageLink = tapGesture.CommandParameter.ToString();

            await PopupNavigation.Instance.PushAsync(new PhotoViewPopup(MovieDetailPageViewModel.Movie.MovieDetails.Image));

            await Task.Delay(250);
            IsClicked = false;
        }
        //========== Function Method ===========
        private async Task ClosePage()
        {
            _ = PopupNavigation.Instance.PushAsync(CloseTransition);
            await Task.Delay(200);
            await Navigation.PopAsync(false);
        }
        //========== Object/Bool Area =============
        public MovieDetailPageViewModel MovieDetailPageViewModel;
        private CloseTransitionPopup CloseTransition = new CloseTransitionPopup(400);
        private bool IsClicked = false;
        private bool IsBooking = false; // For redirect use


    }
}