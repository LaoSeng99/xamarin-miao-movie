using BXM308_Assignment.Model;
using BXM308_Assignment.PageViewModel;
using BXM308_Assignment.Popup;
using BXM308_Assignment.ViewModels;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BXM308_Assignment
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MovieCategoryPage : ContentPage
    {
        private string NavTo = null;
        public MovieCategoryPage(string navTo, ObservableCollection<MovieViewModel> movieList)
        {
            NavTo = navTo;

            InitializeComponent();

            MessagingCenter.Subscribe<App, FilterClass>((App)Application.Current, "ApplyingTag", async (sender, filter) =>
            {
                IsApplying = true;
                await Task.Delay(200);
                await PopupNavigation.Instance.PushAsync(new ApplyingPopup());

                await Task.Delay(1500);
                await PopupNavigation.Instance.PopAllAsync();
                IsApplying = false;
            });

            viewModel = new MovieCategoryPageViewModel(movieList);
            this.BindingContext = viewModel;

            searchTimer = new Timer(1000); // 1000毫秒 = 1秒
            searchTimer.Elapsed += StartSearchMovie;
            searchTimer.AutoReset = false; // 只执行一次



        }
        protected override bool OnBackButtonPressed()
        {
            if (IsApplying)
                return true;
            if (PopupNavigation.Instance.PopupStack.Count > 0)
            {
                PopupNavigation.Instance.PopAsync();
                return true;
            }
            _ = ClosePage();
            return true;
        }
        protected async override void OnAppearing()
        {
            if (this.BindingContext is BaseViewModel viewMode)
                viewMode.LoadCommand.Execute(null);

            if (PageContent.Opacity == 0)
            {
                await Task.Delay(200);
                await PageContent.FadeTo(1, 200, Easing.Linear);
            }
            await Task.Delay(200);
            if (NavTo != null && NavTo == "Filter")
            {
                var list = this.viewModel.GetCategoriesString();
                await PopupNavigation.Instance.PushAsync(new CategoryPopup(list));
            }
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }

        //========== Navigate Page ===============
        private async void Nav_ClosePage(object sender, EventArgs e)
        {
            if (IsClicked || IsApplying)
                return;
            IsClicked = true;
            //Main Function
            await ClosePage();

            await Task.Delay(250);
            IsClicked = false;
        }
        private async void Nav_CategoryPopup(object sender, EventArgs e)
        {
            if (IsClicked)
                return;
            IsClicked = true;

            var cateList = viewModel.GetCategoriesString();
            await PopupNavigation.Instance.PushAsync(new CategoryPopup(cateList));
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

            var findMovie = viewModel.GetSelectedMovie(movieId);

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

            var findMovie = viewModel.GetSelectedMovie(movieId);

            var image = (Image)stack.Children.First();
            ImageClickedAnimation(image);

            //Open Movie Detail Page
            await PopupNavigation.Instance.PushAsync(transitionPopup);
            //Redirect to booking page == true
            await Navigation.PushAsync(new MovieDetailPage(findMovie, true), false);


            await Task.Delay(250);
            IsClicked = false;
        }
        //========== Function Method ===========
        private async Task ClosePage()
        {
            MessagingCenter.Unsubscribe<App>((App)Application.Current, "ApplyingTag");
            await PageContent.FadeTo(0, 200, Easing.Linear);
            await PopupNavigation.Instance.PushAsync(BookingCloseTransitionPopup);
            _ = Navigation.PopAsync(false);
        }
        private async void ImageClickedAnimation(Image image)
        {
            await image.ScaleTo(0.90, 45, Easing.Linear);
            _ = image.ScaleTo(1.1, 45, Easing.Linear);
            _ = image.ScaleTo(1, 45, Easing.Linear);
        }
        private async void RemoveCategoryTag_Clicked(object sender, EventArgs e)
        {
            var frame = sender as Frame;
            await frame.ScaleTo(0.90, 45, Easing.Linear);
            _ = frame.ScaleTo(1.1, 45, Easing.Linear);
            _ = frame.ScaleTo(1, 45, Easing.Linear);
        }
        private void SearchMovie_Changed(object sender, TextChangedEventArgs e)
        {
            if (viewModel.ResultList?.Count > 0)
                viewModel.ResultList.Clear();
            if (!viewModel.IsSearching)
                viewModel.IsSearching = true;
            //Show Loading
            userInput = e.NewTextValue;

            searchTimer.Stop();
            searchTimer.Start();
        }
        private void StartSearchMovie(object sender, ElapsedEventArgs e)
        {
            if (string.IsNullOrEmpty(userInput))
            {
                viewModel.ResultList = null;
                viewModel.IsSearching = false;
                return;
            }
            viewModel.SearchingMovie(userInput);

        }
        //========== Object/Bool Area =============
        private MovieCategoryPageViewModel viewModel;
        private BookingCloseTransitionPopup BookingCloseTransitionPopup = new BookingCloseTransitionPopup(300);
        private Timer searchTimer;
        private bool IsClicked = false;
        private bool IsApplying = false;
        private string userInput;
        private TransitionPopup transitionPopup = new TransitionPopup(400);








    }
}