using BXM308_Assignment.Interfaces;
using BXM308_Assignment.Model;
using BXM308_Assignment.PageViewModel;
using BXM308_Assignment.Popup;
using BXM308_Assignment.ViewModels;
using Plugin.Toasts;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;

using System;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

using System.Threading.Tasks;
using System.Timers;
using Xamarin.CommunityToolkit.UI.Views.Options;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Application = Xamarin.Forms.Application;
using Entry = Xamarin.Forms.Entry;

namespace BXM308_Assignment
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            MainPageViewModel = new MainPageViewModel();
            this.BindingContext = MainPageViewModel;

            MessagingCenter.Subscribe<App>((App)Application.Current, "Nav_ToTicket", async (sender) =>
            {
                MainPageViewModel.ClearAllTickets();
                MainPageViewModel.Nav_Ticket("Ticket");

            });
            MessagingCenter.Subscribe<App>((App)Application.Current, "LogOut", (sender) =>
            {
                MainPageViewModel.IsLogged = false;
                MainPageViewModel.LoggedUser = null;
            });
            MessagingCenter.Subscribe<App, UserVM>((App)Application.Current, "LogInSuccess", async (sender, user) =>
            {
                MainPageViewModel.IsLogged = true;
                MainPageViewModel.LoggedUser = user;
                await MainPageViewModel.GetUserTickets();
                await AppPreferences.SetString("UserId", user.UserRefId);
            });

            searchTimer = new Timer(1000); // 1000毫秒 = 1秒
            searchTimer.Elapsed += StartSearchMovie;
            searchTimer.AutoReset = false; // 只执行一次
        }
        protected override bool OnBackButtonPressed()
        {
            if (PopupNavigation.Instance.PopupStack.Count > 0)
            {
                PopupNavigation.Instance.PopAsync();
                return true;
            }

            if (searchContainer.IsVisible)
            {
                CloseSearchContainer();
                return true;
            }

            Device.BeginInvokeOnMainThread(async () =>
            {
                var asking = await DisplayAlert("Exit Confirmation", "Are you sure you want to exit?", "Yes", "No");

                if (asking)
                    System.Diagnostics.Process.GetCurrentProcess().Kill();
            });

            return true;
        }
        protected override async void OnAppearing()
        {
            if (BindingContext is BaseViewModel viewModel)
                viewModel.LoadCommand.Execute(null);

            if (IsShowReload)
                return;

            // Show the popup to ask the user whether to reload movie tickets
            bool reload = await DisplayAlert(
                "Reload Movie Tickets?",
                "Reloading all movie tickets may take some time. If the app is not working properly, please use this feature. Do you want to reload now?",
                "Yes",
                "No"
            );
            if (!reload)
            {
                IsShowReload = true;
                await DisplayAlert("Attention", "Some feature may not working properly. If want to reload, you may re-open this app", "Ok");
                return;
            }
            bool confirm = await DisplayAlert("Operation in Progress", "Reloading all movie shows may take around 7 to 15 minutes. Please be patient.", "Start", "Cancel");

            if (!confirm)
            {
                IsShowReload = true;

                await DisplayAlert("Attention", "Some feature may not working properly. If want to reload, you may re-open this app", "Ok");
                return;
            }
            if (confirm)
            {
                await ReloadMovieTicketsAsync();
                // Start the reload process
            }
        }
        //========== Navigate Page ===============
        private async void Nav_BottomTrip(object sender, EventArgs e)
        {
            if (IsClicked)
                return;
            IsClicked = true;

            CloseSearchContainer();
            var stack = sender as StackLayout;
            var tapGesture = stack.GestureRecognizers[0] as TapGestureRecognizer;
            var navTo = tapGesture.CommandParameter.ToString();
            switch (navTo)
            {
                case "Home":
                    MainPageViewModel.Nav_Home(navTo);
                    break;
                case "Ticket":
                    MainPageViewModel.Nav_Ticket(navTo);
                    break;
                case "Favorite":
                    MainPageViewModel.Nav_Favorite(navTo);
                    break;
                case "User":
                    MainPageViewModel.Nav_User(navTo);
                    break;
                case "Movie":
                    MainPageViewModel.Nav_Movie(navTo);
                    break;
            }

            await Task.Delay(250);
            IsClicked = false;
        }
        private async void Nav_Movie(object sender, EventArgs e)
        {
            if (IsClicked)
                return;
            IsClicked = true;
            //End
            MainPageViewModel.Nav_Movie("Movie");

            await Task.Delay(250);
            IsClicked = false;
        }
        private async void Nav_MovieDetails(object sender, EventArgs e)
        {
            if (IsClicked)
                return;
            IsClicked = true;

            var stack = sender as StackLayout;
            var tapGesture = stack.GestureRecognizers[0] as TapGestureRecognizer;
            var movieId = tapGesture.CommandParameter.ToString();

            var findMovie = MainPageViewModel.GetSelectedMovie(movieId);

            //Open Movie Detail Page
            await PopupNavigation.Instance.PushAsync(transitionPopup);
            //Redirect to booking page == true
            await Navigation.PushAsync(new MovieDetailPage(findMovie, false), false);

            await Task.Delay(250);
            IsClicked = false;
        }
        private async void Nav_MovieBooking(object sender, EventArgs e)
        {
            if (IsClicked)
                return;
            IsClicked = true;

            var stack = sender as StackLayout;
            var tapGesture = stack.GestureRecognizers[0] as TapGestureRecognizer;
            var movieId = tapGesture.CommandParameter.ToString();

            var findMovie = MainPageViewModel.GetSelectedMovie(movieId);

            var image = (Image)stack.Children.First();
            ImageClickedAnimation(image);

            //Open Movie Detail Page
            await PopupNavigation.Instance.PushAsync(transitionPopup);
            //Redirect to booking page == true
            await Navigation.PushAsync(new MovieDetailPage(findMovie, true), false);


            await Task.Delay(250);
            IsClicked = false;
        }
        private async void Nav_SearchPopup(object sender, EventArgs e)
        {
            if (IsClicked)
                return;
            IsClicked = true;
            var frame = sender as Frame;

            //Animation
            _ = frame.ScaleTo(1.1, 200, Easing.Linear);
            var toPositionX = -App.Current.MainPage.Width + 72;

            searchContainer.IsVisible = true;
            await frame.TranslateTo(toPositionX, 6, 200, Easing.Linear);
            await searchContainer.FadeTo(1, 200, Easing.Linear);
            HomeSearchEntry.Focus();
            if (SearchFrame == null)
                SearchFrame = frame;

            frame.Scale = 1;
            await Task.Delay(100);
            IsClicked = false;
        }
        private async void Nav_SettingPopup(object sender, EventArgs e)
        {
            if (IsClicked)
                return;
            IsClicked = true;


            await PopupNavigation.Instance.PushAsync(new BookingTransitionPopup(400));
            await Navigation.PushAsync(new SettingPage(MainPageViewModel.IsLogged), false);

            await Task.Delay(250);
            IsClicked = false;
        }
        private async void Nav_UserLoginPage(object sender, EventArgs e)
        {
            if (IsClicked)
                return;
            IsClicked = true;


            await PopupNavigation.Instance.PushAsync(new BookingTransitionPopup(400));
            await Navigation.PushAsync(new UserLoginPage(), false);

            await Task.Delay(250);
            IsClicked = false;
        }
        private async void Nav_MovieCategoryPage(object sender, EventArgs e)
        {
            if (IsClicked)
                return;

            IsClicked = true;

            Frame frame = sender as Frame;
            StackLayout stack = sender as StackLayout;
            TapGestureRecognizer tapGesture = null;

            if (frame == null)
                tapGesture = stack.GestureRecognizers[0] as TapGestureRecognizer;
            if (stack == null)
                tapGesture = frame.GestureRecognizers[0] as TapGestureRecognizer;

            var navTo = tapGesture.CommandParameter.ToString();

            await PopupNavigation.Instance.PushAsync(new BookingTransitionPopup(400));
            await Navigation.PushAsync(new MovieCategoryPage(navTo, MainPageViewModel.MoviePageMovies), false);


            await Task.Delay(250);
            IsClicked = false;
        }
        private async void Nav_ClaimTicketPopup(object sender, EventArgs e)
        {
            if (IsClicked)
                return;

            IsClicked = true;

            Frame frame = sender as Frame;
            TapGestureRecognizer tapGesture = frame.GestureRecognizers[0] as TapGestureRecognizer;
            string ticketId = tapGesture.CommandParameter.ToString();

            TicketVM founded = MainPageViewModel.GetSelectedTicket(ticketId);

            await PopupNavigation.Instance.PushAsync(new ClaimTicketPopup(founded));
            await Task.Delay(250);
            IsClicked = false;
        }
        //========== Function Method ===========
        private async Task ReloadMovieTicketsAsync()
        {

            await PopupNavigation.Instance.PushAsync(new Loading());

            // Simulate a long-running task (e.g., fetching data from an API)
            await MainPageViewModel.AutomationCreateShow();


            await PopupNavigation.Instance.PopAsync();

            await DisplayAlert("Success", "Movie tickets have been successfully reloaded.", "Reload App");
            var appRestartService = DependencyService.Get<IAppService>();
            appRestartService?.RestartApp();
        }
        private async void Update_MainBoardMovie(object sender, EventArgs e)
        {
            if (IsClicked)
                return;
            IsClicked = true;

            var frame = sender as Frame;
            var tapGesture = frame.GestureRecognizers[0] as TapGestureRecognizer;
            var updateTo = tapGesture.CommandParameter.ToString();

            await frame.ScaleTo(0.95, 45, Easing.Linear);
            _ = frame.ScaleTo(1.05, 45, Easing.Linear);
            _ = frame.ScaleTo(1, 45, Easing.Linear);

            switch (updateTo)
            {
                case "Showing":
                    MainPageViewModel.UpdateMainBoardToShowing();
                    break;
                case "ComingSoon":
                    MainPageViewModel.UpdateMainBoardToComing(); break;
            }

            await Task.Delay(150);
            IsClicked = false;
        }
        private async void ImageClickedAnimation(Image image)
        {
            await image.ScaleTo(0.90, 45, Easing.Linear);
            _ = image.ScaleTo(1.1, 45, Easing.Linear);
            _ = image.ScaleTo(1, 45, Easing.Linear);
        }
        private async void CloseSearchContainer()
        {
            if (SearchFrame == null || HomeSearchEntry.IsFocused)
                return;

            await searchContainer.FadeTo(0, 150, Easing.Linear);
            _ = SearchFrame.TranslateTo(0, 0, 200, Easing.Linear);
            searchContainer.IsVisible = false;
        }
        private void ShowHeaderBackground(object sender, ScrolledEventArgs e)
        {
            if (e.ScrollY > 165)
            {
                ProfileHeader.BackgroundColor = Color.FromHex("#080808");
                return;
            }

            ProfileHeader.BackgroundColor = Color.Transparent;

        }
        private void Quit_SearchContainer(object sender, EventArgs e)
        {
            CloseSearchContainer();
        }
        private void SearchMovie_Changed(object sender, TextChangedEventArgs e)
        {
            if (MainPageViewModel.SearchResultMovie?.Count > 0)
                MainPageViewModel.SearchResultMovie.Clear();
            if (!MainPageViewModel.IsSearching)
                MainPageViewModel.IsSearching = true;
            //Show Loading
            userInput = e.NewTextValue;

            searchTimer.Stop();
            searchTimer.Start();
        }
        private void StartSearchMovie(object sender, ElapsedEventArgs e)
        {
            if (string.IsNullOrEmpty(userInput))
            {
                MainPageViewModel.SearchResultMovie = null;
                MainPageViewModel.IsSearching = false;
                return;
            }
            MainPageViewModel.SearchingMovie(userInput);

        }
        //========== Object/Bool Area =============
        public MainPageViewModel MainPageViewModel;
        private TransitionPopup transitionPopup = new TransitionPopup(400);
        private Frame SearchFrame;
        private Timer searchTimer;
        private string userInput;
        private bool IsClicked = false;
        private bool IsShowReload = false;
        private void BlockPanel(object sender, EventArgs e)
        {
            return;
        }

        private async void TicktLoadMore_Clicked(object sender, EventArgs e)
        {
            //For double clicked check
            if (IsClicked)
                return;
            IsClicked = true;
            //Main Function


            var frame = sender as Frame;
            var tapGesture = frame.GestureRecognizers[0] as TapGestureRecognizer;
            var loadTo = tapGesture.CommandParameter.ToString();
            switch (loadTo)
            {
                case "Claim":
                    MainPageViewModel.LoadMoreActiveTicket();
                    break;
                case "Review":
                    MainPageViewModel.LoadMoreReviewTicket();
                    break;
                case "Expired":
                    MainPageViewModel.LoadMoreExpiredTicket();
                    break;
            }


            await Task.Delay(250);
            IsClicked = false;

        }

        private void TicketFrame_Clicked(object sender, EventArgs e)
        {
            //var frame = sender as Frame;
            //var tapGesture = frame.GestureRecognizers[0] as TapGestureRecognizer;
            //var id = tapGesture.CommandParameter.ToString();

            //a popup for claim Ticket
        }


    }
}
