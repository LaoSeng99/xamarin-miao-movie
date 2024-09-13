using BXM308_Assignment.Firebase;
using BXM308_Assignment.Model;
using BXM308_Assignment.PageViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Design;
using System.Data.Common;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace BXM308_Assignment.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        #region RoomsUpdate
        //public static ObservableCollection<Room> Rooms = new ObservableCollection<Room>()
        //{
        //    new Room()
        //{
        //    Id = "Room-00001",
        //        RoomId = "",
        //        Date = DateTime.Now.Date.ToString(),
        //        TimeShow = new List<RoomTime>()
        //        {
        //            new RoomTime()
        //            {
        //                Time = "10:00 AM",
        //                MovieId="1",
        //                RoomSeatStatus= new List<RoomSeat>()
        //                {
        //                    new RoomSeat()
        //                    {
        //                        Code= "A-01",
        //                        Status="Available",
        //                    },
        //                    new RoomSeat()
        //                    {
        //                        Code= "A-02",
        //                        Status="Available",
        //                    },
        //                },
        //                IsFull=false,
        //            },
        //            new RoomTime()
        //            {
        //                Time = "11:55 AM",
        //                MovieId="1",
        //                RoomSeatStatus= new List<RoomSeat>()
        //                {
        //                    new RoomSeat()
        //                    {
        //                        Code= "A-01",
        //                        Status="Available",
        //                    },
        //                    new RoomSeat()
        //                    {
        //                        Code= "A-02",
        //                        Status="Available",
        //                    },
        //                },
        //                IsFull=false,
        //            },
        //        }
        //    },
        //};
        #endregion
        //Main Method
        public List<MovieViewModel> movieList;
        protected override async void OnLoadCommandExecute()
        {
            if (IsDataLoad)
                return;
            //Add Movie List
            string trailerLinkFormat1 = "<iframe src='https://www.youtube.com/embed/";
            string trailerLinkFormat2 = "?autoplay=0&controls=0' allowtransparency='true' style='-webkit-transform:scale(1.085);-moz-transform-scale(1.085);overflow: hidden;' height='100%' width='100%' frameborder='0' marginwidth='0' marginheight='0' hspace='0' vspace='0' scrolling='no' style='border: none;'></iframe>";
            movieList = new List<MovieViewModel>()
            {
                //Rogue One: A Star Wars Story
                new MovieViewModel()
                {  Id ="1",
                    MovieId=Guid.NewGuid().ToString(),
                    Poster="Movie1",
                    TrailerLink=$"{trailerLinkFormat1}frdj1zb9sMY{trailerLinkFormat2}",
                    StarRate=3.2,
                    Sales=617,
                    Rating="PG-13",
                    IsShowing=true,
                    Price=8,
                    Review=168,
                    ReleaseDate="13 JUL, 2022",
                    MovieDetails=new MovieDetails()
                    {
                       Title="Rogue One: A Star Wars Story",
                       Genre="Science fiction,Action,Space opera",
                       Actor=new ObservableCollection<Actor>(){
                           new Actor(){ Name= "Felicity Jones",Image="FelicityJones" },
                           new Actor(){ Name= "Diego Luna",Image="DiegoLuna" },
                           new Actor(){ Name= "Donnie Yen",Image="DonnieYen" },
                           new Actor(){ Name= "Ben Mendelsohn",Image="BenMendelsohn" },
                           new Actor(){ Name= "Mads Dittmann MikkelsenR",Image="MadsDittmannMikkelsenR" },
                        } ,
                       Director=new ObservableCollection<Director>(){
                           new Director() { Name = "Gareth Edwards", Image = "GarethEdwards" }
                       },
                       Language="English",
                       Duration=new TimeSpan(2, 13, 0),
                       Description="A story set apart from the classic installments of the Star Wars saga, Rogue One brings a unique perspective to the galaxy far, far away. Directed by Gareth Edwards, the film tells of Rebel soldier Jyn Erso (Felicity Jones) and her band of fighters who attempt to discover a secret to the Death Star's destruction.",
                       Image=new ObservableCollection<MovieImage>(){
                          new MovieImage(){Name="Movie1",Image="Movie1"},
                          new MovieImage(){Name="Movie1_1",Image="Movie1_1"},
                          new MovieImage(){Name="Movie1_2",Image="Movie1_2"},
                          new MovieImage(){Name="Movie1_3",Image="Movie1_3"},
                          new MovieImage(){Name="Movie1_4",Image="Movie1_4"},
                          new MovieImage(){Name="Movie1_5",Image="Movie1_5"},
                          new MovieImage(){Name="Movie1_6",Image="Movie1_6"},
                          new MovieImage(){Name="Movie1_7",Image="Movie1_7"},
                       }
                    }
                },
                //65
                new MovieViewModel()
                {
                    Id = "2",
                    MovieId = Guid.NewGuid().ToString(),
                    Poster = "Movie2",
                    TrailerLink = $"{trailerLinkFormat1}bHXejJq5vr0{trailerLinkFormat2}",
                    StarRate = 3.5,
                    Sales = 452,
                      Price=12,
                    Rating = "PG-13",
                    IsShowing = true,
                    Review = 234,
                    ReleaseDate = "13 AUG, 2022",
                    MovieDetails = new MovieDetails()
                    {
                        Title = "65",
                        Genre = "Science fiction,Action,Thriller",
                        Actor = new ObservableCollection<Actor>(){
                           new Actor(){ Name= "Adam Driver",Image="AdamDriver" },
                           new Actor(){ Name= "Ariana Greenblatt",Image="ArianaGreenblatt" },
                           new Actor(){ Name= "Chloe Coleman",Image="ChloeColeman" },
                           new Actor(){ Name= "Nika King",Image="NikaKing" },
                           new Actor(){ Name= "Alexandra Shipp",Image="AlexandraShipp" },
                         },
                        Director=new ObservableCollection<Director>(){
                           new Director() { Name = "Scott Beck", Image = "ScottBeck" },
                           new Director() { Name = "Bryan Woods", Image = "BryanWoods" },
                        },
                        Language = "English",
                        Duration = new TimeSpan(1, 33, 0),
                        Description = "65 is a 2023 American science fiction action thriller film written and directed by Scott Beck and Bryan Woods and starring Adam Driver and Ariana Greenblatt. In the film, a pilot crashes on an unknown planet and attempts to escape while surviving with a young girl",
                        Image=new ObservableCollection<MovieImage>(){
                          new MovieImage(){Name="Movie2",Image="Movie2"},
                          new MovieImage(){Name="Movie2_1",Image="Movie2_1"},
                          new MovieImage(){Name="Movie2_2",Image="Movie2_2"},
                          new MovieImage(){Name="Movie2_3",Image="Movie2_3"},
                          new MovieImage(){Name="Movie2_4",Image="Movie2_4"},
                          new MovieImage(){Name="Movie2_5",Image="Movie2_5"},
                          new MovieImage(){Name="Movie2_6",Image="Movie2_6"},
                       }
                    }
                },
                //Avenger End Game
                new MovieViewModel()
                {
                    Id ="3",
                    MovieId = Guid.NewGuid().ToString(),
                    Poster = "Movie3",
                    TrailerLink = $"{trailerLinkFormat1}TcMBFSGVi1c{trailerLinkFormat2}",
                    StarRate = 4.9,
                    Sales = 947,
                      Price=9,
                    Rating = "PG-13",
                    IsShowing = true,
                    Review = 324,
                    ReleaseDate = "13 MAR, 2023",
                    MovieDetails = new MovieDetails()
                    {
                        Title = "Avengers: Endgame",
                        Genre = "Action,Super Hero,Science fiction",
                        Actor = new ObservableCollection<Actor>()
                        {
                           new Actor(){ Name= "Robert Downey Jr",Image="RobertDowneyJr" },
                           new Actor(){ Name= "Chris Evans",Image="ChrisEvans" },
                           new Actor(){ Name= "Scarlett Johansson",Image="ScarlettJohansson" },
                           new Actor(){ Name= "Christopher Hemsworth",Image="ChristopherHemsworth" },
                           new Actor(){ Name= "MarkAlanRuffalo",Image="MarkAlanRuffalo" },
                        },
                        Director=new ObservableCollection<Director>(){
                           new Director() { Name = "Anthony Russo", Image = "AnthonyRusso" },
                           new Director() { Name = "Joe Russo", Image = "JoeRusso" },
                        },
                        Language = "English",
                        Duration = new TimeSpan(3, 02, 0),
                        Description = "With the help of remaining allies, the Avengers must assemble once more in order to undo Thanos's actions and undo the chaos to the universe, no matter what consequences may be in store, and no matter who they face... Avenge the fallen.",
                        Image=new ObservableCollection<MovieImage>(){
                          new MovieImage(){Name="Movie3",Image="Movie3"},
                          new MovieImage(){Name="Movie3_1",Image="Movie3_1"},
                          new MovieImage(){Name="Movie3_2",Image="Movie3_2"},
                          new MovieImage(){Name="Movie3_3",Image="Movie3_3"},
                          new MovieImage(){Name="Movie3_4",Image="Movie3_4"},
                          new MovieImage(){Name="Movie3_5",Image="Movie3_5"},
                          new MovieImage(){Name="Movie3_6",Image="Movie3_6"},
                          new MovieImage(){Name="Movie3_7",Image="Movie3_7"},
                        }
                    }
                },
                //Doctor Stange
                new MovieViewModel()
                {
                    Id = "4",
                    MovieId = Guid.NewGuid().ToString(),
                    Poster = "Movie4",
                    TrailerLink = $"{trailerLinkFormat1}aWzlQ2N6qqg{trailerLinkFormat2}",
                    StarRate = 0,
                    Sales = 0,
                      Price=14,
                    Rating = "PG-13",
                    IsShowing = false,
                    Review = 0,
                    ReleaseDate = "12 OCT, 2023",
                    MovieDetails = new MovieDetails()
                    {
                        Title = "Doctor Strange in the Multiverse of Madness",
                        Genre = "Super Hero,Action,Thriller",
                        Actor = new ObservableCollection<Actor>()
                        {
                           new Actor(){ Name= "Xochitl Gomez",Image="XochitlGomez" },
                           new Actor(){ Name= "Elizabeth Olsen",Image="ElizabethOlsen" },
                           new Actor(){ Name= "John Krasinski",Image="JohnKrasinski" },
                           new Actor(){ Name= "Rachel McAdams",Image="RachelMcAdams" },
                           new Actor(){ Name= "Hayley Atwell",Image="HayleyAtwell" },
                        },
                        Director=new ObservableCollection<Director>(){
                           new Director() { Name = "Sam Raimi", Image = "SamRaimi" },
                        },
                        Language = "English",
                        Duration = new TimeSpan(2, 06, 0),
                        Description = "Doctor Strange teams up with a mysterious teenage girl from his dreams who can travel across multiverses, to battle multiple threats, including other-universe versions of himself, which threaten to wipe out millions across the multiverse. They seek help from Wanda the Scarlet Witch, Wong and others.",
                        Image=new ObservableCollection<MovieImage>(){
                          new MovieImage(){Name="Movie4",Image="Movie4"},
                          new MovieImage(){Name="Movie4_1",Image="Movie4_1"},
                          new MovieImage(){Name="Movie4_2",Image="Movie4_2"},
                          new MovieImage(){Name="Movie4_3",Image="Movie4_3"},
                          new MovieImage(){Name="Movie4_4",Image="Movie4_4"},
                          new MovieImage(){Name="Movie4_5",Image="Movie4_5"},
                          new MovieImage(){Name="Movie4_6",Image="Movie4_6"},
                        }
                    }
                },
                //Galaxy
                new MovieViewModel()
                {
                    Id ="5",
                    MovieId = Guid.NewGuid().ToString(),
                    Poster = "Movie5",
                    TrailerLink = $"{trailerLinkFormat1}u3V5KDHRQvk{trailerLinkFormat2}",
                    StarRate = 0,
                    Sales = 0,
                      Price=6,
                    Rating = "PG-13",
                    IsShowing = false,
                    Review = 0,
                    ReleaseDate = "23 NOV, 2023",
                    MovieDetails = new MovieDetails()
                    {
                        Title = "Guardians of the Galaxy",
                        Genre = "Action,Super Hero,Comedy",
                        Actor = new ObservableCollection<Actor>()
                        {
                           new Actor(){ Name= "James Gunn",Image="JamesGunn" },
                           new Actor(){ Name= "Chris Pratt",Image="ChrisPratt" },
                           new Actor(){ Name= "Zoe Saldaña",Image="ZoeSaldana" },
                           new Actor(){ Name= "Vin Diesel",Image="VinDiesel" },
                           new Actor(){ Name= "Sean Gunn",Image="SeanGunn" },
                        },
                        Director=new ObservableCollection<Director>(){
                           new Director() { Name = "James Gunn", Image = "JamesGunn" },
                        },
                        Language = "English",
                        Duration = new TimeSpan(2, 29, 0),
                        Description = "A group of intergalactic criminals must pull together to stop a fanatical warrior with plans to purge the universe.",
                        Image=new ObservableCollection<MovieImage>(){
                          new MovieImage(){Name="Movie5",Image="Movie5"},
                          new MovieImage(){Name="Movie5_1",Image="Movie5_1"},
                          new MovieImage(){Name="Movie5_2",Image="Movie5_2"},
                          new MovieImage(){Name="Movie5_3",Image="Movie5_3"},
                          new MovieImage(){Name="Movie5_4",Image="Movie5_4"},
                          new MovieImage(){Name="Movie5_5",Image="Movie5_5"},
                          new MovieImage(){Name="Movie5_6",Image="Movie5_6"},
                        }
                    }
                },
                //Dead Pool 
                new MovieViewModel()
                {
                    Id = "6",
                    MovieId = Guid.NewGuid().ToString(),
                    Poster = "Movie6",
                    TrailerLink = $"{trailerLinkFormat1}ONHBaC-pfsk{trailerLinkFormat2}",
                    StarRate = 4.3,
                    Price = 7,
                    Sales = 577,
                    Rating = "R",
                    IsShowing = true,
                    Review = 28,
                    ReleaseDate = "13 MAR, 2023",
                    MovieDetails = new MovieDetails()
                    {
                        Title = "DeadPool",
                        Genre = "Comedy,Action,Super Hero",
                        Actor = new ObservableCollection<Actor>()
                        {
                           new Actor(){ Name= "Ryan Reynolds",Image="RyanReynolds" },
                           new Actor(){ Name= "Morena Baccarin",Image="MorenaBaccarin" },
                           new Actor(){ Name= "Paul Wernick",Image="PaulWernick" },
                           new Actor(){ Name= "Leslie Uggams",Image="LeslieUggams" },
                           new Actor(){ Name= "Karan Soni",Image="KaranSoni" },
                        },
                        Director=new ObservableCollection<Director>(){
                           new Director() { Name = "Shawn Levy", Image = "ShawnLevy" },
                           new Director() { Name = "Tim Miller", Image = "TimMiller" },
                           new Director() { Name = "David Leitch", Image = "DavidLeitch" },
                        },
                        Language = "English",
                        Duration = new TimeSpan(1, 48, 0),
                        Description = "Wade Wilson (Ryan Reynolds) is a former Special Forces operative who now works as a mercenary. His world comes crashing down when evil scientist Ajax (Ed Skrein) tortures, disfigures and transforms him into Deadpool. The rogue experiment leaves Deadpool with accelerated healing powers and a twisted sense of humor.",
                       Image=new ObservableCollection<MovieImage>(){
                          new MovieImage(){Name="Movie6",Image="Movie6"},
                          new MovieImage(){Name="Movie6_1",Image="Movie6_1"},
                          new MovieImage(){Name="Movie6_2",Image="Movie6_2"},
                          new MovieImage(){Name="Movie6_3",Image="Movie6_3"},
                          new MovieImage(){Name="Movie6_4",Image="Movie6_4"},
                          new MovieImage(){Name="Movie6_5",Image="Movie6_5"},
                          new MovieImage(){Name="Movie6_6",Image="Movie6_6"},
                          new MovieImage(){Name="Movie6_7",Image="Movie6_7"},
                       }
                    }
                },

            };
            //Display
            MainBoardShowingMovie = movieList.Where(c => c.IsShowing == true).ToList();
            TrendingMovie = movieList.Where(c => c.IsShowing == true).OrderByDescending(c => c.Sales).Take(3).ToList();
            NavHomeBackground = ActiveBackgroundColor;

            //Poster
            MainPoster = new List<string> {
                "Movie1",
                "Movie2",
                "Movie3",
                "Movie4",
                "Movie5",
                "Movie6",

            };

            //Check User Is Logged
            string userId = await AppPreferences.GetString("UserId");
            IsLogged = userId != null;
            if (userId != null)
            {
                LoggedUser = await Firebase.Firebase.GetUserByFirebaseKey(userId);
            }

            //Complete Data Load
            IsDataLoad = true;

        }
        private bool IsDataLoad = false;
        public MovieViewModel GetSelectedMovie(string movieId)
        {
            var findMovie = movieList.FirstOrDefault(c => c.MovieId == movieId);
            return findMovie;
        }
        #region HomePage

        public void SearchingMovie(string input)
        {
            //Find Category
            //var find = movieList.Where(c => c.MovieDetails.Genre.Split(',')
            //           .Select(genre => genre.ToLower())
            //           .Contains(input.ToLower()));
            //Find Include Genre
            //var find = movieList.Where(c => c.MovieDetails.Genre.Split(',')
            //           .Select(genre => genre.ToLower())
            //           .Any(genre => genre.Contains(input.ToLower()))).ToList();
            var find = movieList.Where(c => c.MovieDetails.Title.ToLower()
                                             .Contains(input.ToLower()))
                                .ToList();

            IsSearching = false;
            SearchResultMovie = new ObservableCollection<MovieViewModel>(find);

        }
        #region Home Page Source
        //private
        private List<MovieViewModel> mainBoardShowingMovie;
        private List<MovieViewModel> trendingMovie;
        private ObservableCollection<MovieViewModel> searchResultMovie;
        private List<string> mainPoster;
        private bool isSearching = false;
        //publiic
        public List<MovieViewModel> MainBoardShowingMovie
        {
            get => mainBoardShowingMovie;
            set => SetProperty(ref mainBoardShowingMovie, value);
        }
        public List<MovieViewModel> TrendingMovie
        {
            get => trendingMovie;
            set => SetProperty(ref trendingMovie, value);
        }
        public ObservableCollection<MovieViewModel> SearchResultMovie
        {
            get => searchResultMovie;
            set => SetProperty(ref searchResultMovie, value);
        }
        public List<string> MainPoster
        {
            get => mainPoster;
            set => SetProperty(ref mainPoster, value);
        }
        public bool IsSearching
        {
            get => isSearching;
            set => SetProperty(ref isSearching, value);
        }
        #endregion
        #region MainBoard Movie
        //private default Showing #ff6400
        private string showingBorderColor = "#FF6400";
        private string showingTextColor = "#FF6400";
        private string showingFontFamily = "AorusFont_Bold";
        private string comingBorderColor = "#808080";
        private string comingTextColor = "#FFFFFF";
        private string comingFontFamily = "AorusFont_Regular";
        //public
        public string ShowingBorderColor
        {
            get => showingBorderColor;
            set => SetProperty(ref showingBorderColor, value);
        }
        public string ShowingTextColor
        {
            get => showingTextColor;
            set => SetProperty(ref showingTextColor, value);
        }
        public string ShowingFontFamily
        {
            get => showingFontFamily;
            set => SetProperty(ref showingFontFamily, value);
        }
        public string ComingBorderColor
        {
            get => comingBorderColor;
            set => SetProperty(ref comingBorderColor, value);
        }
        public string ComingTextColor
        {
            get => comingTextColor;
            set => SetProperty(ref comingTextColor, value);
        }
        public string ComingFontFamily
        {
            get => comingFontFamily;
            set => SetProperty(ref comingFontFamily, value);
        }
        public void UpdateMainBoardToShowing()
        {
            if (IsMainBoardShowing)
                return;
            ShowingBorderColor = "#FF6400";
            ShowingTextColor = "#FF6400";
            ShowingFontFamily = "AorusFont_Bold";
            ComingBorderColor = "#808080";
            ComingTextColor = "#FFFFFF";
            ComingFontFamily = "AorusFont_Regular";

            MainBoardShowingMovie = movieList.Where(c => c.IsShowing == true).ToList();
            IsMainBoardShowing = true;
        }
        public void UpdateMainBoardToComing()
        {
            if (!IsMainBoardShowing)
                return;
            ShowingBorderColor = "#808080";
            ShowingTextColor = "#FFFFFF";
            ShowingFontFamily = "AorusFont_Regular";
            ComingBorderColor = "#FF6400";
            ComingTextColor = "#FF6400";
            ComingFontFamily = "AorusFont_Bold";
            MainBoardShowingMovie = movieList.Where(c => c.IsShowing == false).ToList();

            IsMainBoardShowing = false;
        }
        private bool IsMainBoardShowing = true;
        #endregion
        #region Navigate Bottom Strip
        //Navigation Function 
        public void Nav_Home(string currentActive)
        {
            SetAllContainersVisibleToFalse(currentActive);
            HomeContainerVisible = true;
            NavHomeBackground = ActiveBackgroundColor;
            NavHomeIcon = "HomeIconOrange";
        }
        public async void Nav_Ticket(string currentActive)
        {

            SetAllContainersVisibleToFalse(currentActive);
            TicketContainerVisible = true;
            NavTicketBackground = ActiveBackgroundColor;
            NavTicketIcon = "TicketIconOrange";

            if (OriginalTicketList == null && IsLogged)
            {
                await GetUserTickets();
            }
        }
        public void Nav_Movie(string currentActive)
        {
            if (MoviePageMovies == null)
                GenerateCateAndMoviePageLists();
            SetAllContainersVisibleToFalse(currentActive);
            MovieContainerVisible = true;
            NavMovieBackground = ActiveBackgroundColor;
            NavMovieIcon = "MovieIconOrange";
        }
        public void Nav_Favorite(string currentActive)
        {
            SetAllContainersVisibleToFalse(currentActive);
            FavoriteContainerVisible = true;
            NavFavoriteBackground = ActiveBackgroundColor;
            NavFavoriteIcon = "FavoriteIconOrange";
        }
        public void Nav_User(string currentActive)
        {
            SetAllContainersVisibleToFalse(currentActive);
            UserContainerVisible = true;
            NavUserBackground = ActiveBackgroundColor;
            NavUserIcon = "UserIconOrange";
        }
        private void SetAllContainersVisibleToFalse(string currentActive)
        {
            if (currentActive == LastActiveStrip)
                return;

            switch (LastActiveStrip)
            {
                case "Home":
                    HomeContainerVisible = false;
                    NavHomeBackground = DeactiveBackgroundColor;
                    NavHomeIcon = "HomeIconWhite";
                    break;
                case "Ticket":
                    TicketContainerVisible = false;
                    NavTicketBackground = DeactiveBackgroundColor;
                    NavTicketIcon = "TicketIconWhite";
                    break;
                case "Favorite":
                    FavoriteContainerVisible = false;
                    NavFavoriteBackground = DeactiveBackgroundColor;
                    NavFavoriteIcon = "FavoriteIconWhite";
                    break;
                case "User":
                    UserContainerVisible = false;
                    NavUserBackground = DeactiveBackgroundColor;
                    NavUserIcon = "UserIconWhite";
                    break;
                case "Movie":
                    MovieContainerVisible = false;
                    NavMovieBackground = DeactiveBackgroundColor;
                    NavMovieIcon = "MovieIconWhite";
                    break;
            }
            LastActiveStrip = currentActive;
        }
        #endregion
        #region Container Visible
        //====== Container Visible ========

        //private (Default Home display)
        private bool homeContainerVisible = true;
        private bool ticketContainerVisible = false;
        private bool movieContainerVisible = false;
        private bool favoriteContainerVisible = false;
        private bool userContainerVisible = false;
        //public (For Frontend use)
        public bool HomeContainerVisible
        {
            get => homeContainerVisible;
            set => SetProperty(ref homeContainerVisible, value);
        }
        public bool TicketContainerVisible
        {
            get => ticketContainerVisible;
            set => SetProperty(ref ticketContainerVisible, value);
        }
        public bool MovieContainerVisible
        {
            get => movieContainerVisible;
            set => SetProperty(ref movieContainerVisible, value);
        }
        public bool FavoriteContainerVisible
        {
            get => favoriteContainerVisible;
            set => SetProperty(ref favoriteContainerVisible, value);
        }
        public bool UserContainerVisible
        {
            get => userContainerVisible;
            set => SetProperty(ref userContainerVisible, value);
        }


        #endregion
        #region Bottom Strip Background
        //====== Bottom Strip Background  =======
        //private default Home
        private LinearGradientBrush navHomeBackground;
        private LinearGradientBrush navTicketBackground;
        private LinearGradientBrush navMovieBackground;
        private LinearGradientBrush navFavoriteBackground;
        private LinearGradientBrush navUserBackground;
        //Active Use
        public LinearGradientBrush ActiveBackgroundColor = new LinearGradientBrush
        {
            EndPoint = new Point(0, 1),
            GradientStops = new GradientStopCollection {
                new GradientStop() { Color = Color.Transparent, Offset = 0 },
                new GradientStop() { Color = Color.FromHex("#080808"), Offset = (float)0.6 },
                new GradientStop() { Color = Color.FromHex("#ff6400"), Offset = (float)0.95 },
            }
        };
        public LinearGradientBrush DeactiveBackgroundColor = new LinearGradientBrush
        {
            EndPoint = new Point(0, 1),
            GradientStops = new GradientStopCollection {
                new GradientStop() { Color = Color.Transparent, Offset = 0 },
                new GradientStop() {Color = Color.FromRgba(0, 0, 0, 0), Offset = 1 },
            }
        };
        public LinearGradientBrush NavHomeBackground
        {
            get => navHomeBackground;
            set => SetProperty(ref navHomeBackground, value);
        }
        public LinearGradientBrush NavTicketBackground
        {
            get => navTicketBackground;
            set => SetProperty(ref navTicketBackground, value);
        }
        public LinearGradientBrush NavMovieBackground
        {
            get => navMovieBackground;
            set => SetProperty(ref navMovieBackground, value);
        }
        public LinearGradientBrush NavFavoriteBackground
        {
            get => navFavoriteBackground;
            set => SetProperty(ref navFavoriteBackground, value);
        }
        public LinearGradientBrush NavUserBackground
        {
            get => navUserBackground;
            set => SetProperty(ref navUserBackground, value);
        }

        public string LastActiveStrip = "Home";
        #endregion
        #region Bottom Stripi Icon
        //====== Bottom Strip Icon  =======
        //private default Home
        private string navHomeIcon = "HomeIconOrange";
        private string navTicketIcon = "TicketIconWhite";
        private string navMovieIcon = "MovieIconWhite";
        private string navFavoriteIcon = "FavoriteIconWhite";
        private string navUserIcon = "UserIconWhite";
        //public
        public string NavHomeIcon
        {
            get => navHomeIcon;
            set => SetProperty(ref navHomeIcon, value);
        }
        public string NavTicketIcon
        {
            get => navTicketIcon;
            set => SetProperty(ref navTicketIcon, value);
        }
        public string NavMovieIcon
        {
            get => navMovieIcon;
            set => SetProperty(ref navMovieIcon, value);
        }
        public string NavFavoriteIcon
        {
            get => navFavoriteIcon;
            set => SetProperty(ref navFavoriteIcon, value);
        }
        public string NavUserIcon
        {
            get => navUserIcon;
            set => SetProperty(ref navUserIcon, value);
        }

        #endregion
        #region Automation Add Movie Show
        public async Task AutomationCreateShow()
        {
            MessagingCenter.Send<App, string>((App)Application.Current, "UpdateReloadStatus", "Step0");
            await Firebase.Firebase.Delete();

            await Task.Delay(1000);
            //Generate Room And Time
            //Step 1 ==== Add Room
            MessagingCenter.Send<App, string>((App)Application.Current, "UpdateReloadStatus", "Step1");
            for (int i = 1; i <= 10; i++)
            {
                await Firebase.Firebase.AddNewRoom(i);
            }
            //Step 2 ==== Add Time
            await Task.Delay(1000);
            MessagingCenter.Send<App, string>((App)Application.Current, "UpdateReloadStatus", "Step2");

            DateTime currentDate = DateTime.UtcNow.AddHours(8).Date;

            //   Loop Each Room For Future 14 days Movie Show
            for (int days = 0; days < 14; days++)
            {
                for (int roomId = 1; roomId <= 10; roomId++)
                {
                    string roomIdString = $"Room-{roomId:D5}";

                    //  Simulate People Arrange Movie Show
                    DateTime date = currentDate.AddDays(days);
                    string dateString = date.ToString("dd MMM yyyy");

                    //  a day, a room, at least show 4 times
                    Random random = new Random();
                    int numShowTimes = random.Next(4, 7);
                    List<string> timeOptions = new List<string> { "10:15 AM", "11:15 AM", "11:30 AM", "12:30 PM", "1:30 PM", "2:45 PM", "3:45 PM", "5:00 PM", "8:00 PM", "7:30 PM", "9:10 PM", "11:30 PM" };

                    for (int j = 0; j < numShowTimes; j++)
                    {
                        //  Random Time Set
                        string randomTime = timeOptions[random.Next(0, timeOptions.Count)];
                        RoomTime roomTime = new RoomTime()
                        {
                            RefId = "",
                            Date = $"{dateString}",
                            RoomId = roomIdString,
                            Time = randomTime,
                            MovieId = random.Next(1, 7).ToString(),
                            Status = "Available",
                            IsFull = false
                        };
                        timeOptions.Remove(randomTime);
                        await Firebase.Firebase.AddNewRoomTime(roomTime);

                    }
                }
            }

            //  Step 3 ==== Get All Time From Firebase
            await Task.Delay(1000);
            MessagingCenter.Send<App, string>((App)Application.Current, "UpdateReloadStatus", "Step3");
            var timeLists = await Firebase.Firebase.GetAllRoomTime();
            Dictionary<char, int> alphaMappings = new Dictionary<char, int>
                {
                    {'A', 0},
                    {'B', 1},
                    {'C', 2},
                    {'D', 3},
                    {'E', 4},
                    {'F', 5},
                };

            List<RoomSeatContainer> roomSeatContainers = new List<RoomSeatContainer>();

            foreach (var time in timeLists)
            {
               
                //    Update themselve Firebae key
                await Firebase.Firebase.UpdateRoomTime(time);
                await Task.Delay(50);
                List<RoomSeat> roomSeats = new List<RoomSeat>();

                for (char row = 'A'; row <= 'F'; row++)
                {
                    for (int seatNum = 0; seatNum <= 12; seatNum++)
                    {
                        int num = seatNum < 6 ? seatNum + 1 : seatNum;

                        string seatCode = $"{row}-{num:D2}";
                        if (seatNum == 6)
                            seatCode = row.ToString();

                        roomSeats.Add(new RoomSeat
                        {
                            Code = seatCode,
                            Status = "Available",
                            InGridColumn = seatNum,
                            InGridRow = alphaMappings[row],
                            IsLabel = seatNum == 6
                        });
                    }
                }

                RoomSeatContainer roomSeat = new RoomSeatContainer()
                {
                    TimeRefId = time.RefId,
                    RoomSeatList = new ObservableCollection<RoomSeat>(roomSeats),
                };
                roomSeatContainers.Add(roomSeat);
            }
            await Task.Delay(1000);
            MessagingCenter.Send<App, string>((App)Application.Current, "UpdateReloadStatus", "Step4");

            foreach (var seat in roomSeatContainers)
            {
                await Firebase.Firebase.AddNewSeat(seat);
                await Task.Delay(100);
            }
        }
        #endregion
        #endregion

        #region UserPage
        private bool isLogged = false;
        public bool IsLogged
        {
            get => isLogged;
            set => SetProperty(ref isLogged, value);
        }

        private User loggedUser;
        public User LoggedUser
        {
            get => loggedUser;
            set => SetProperty(ref loggedUser, value);
        }
        #endregion
        #region Movie Page
        private ObservableCollection<string> categoriesList;
        public ObservableCollection<string> CategoriesList
        {
            get => categoriesList;
            set => SetProperty(ref categoriesList, value);
        }
        private ObservableCollection<MovieViewModel> moviePageMovies;
        public ObservableCollection<MovieViewModel> MoviePageMovies
        {
            get => moviePageMovies;
            set => SetProperty(ref moviePageMovies, value);
        }
        private void GenerateCateAndMoviePageLists()
        {
            MoviePageMovies = new ObservableCollection<MovieViewModel>(movieList);
            List<string> allGenres = new List<string>();

            // 遍历每部电影
            foreach (var movie in MoviePageMovies)
            {
                // 拆分电影的流派并添加到总列表中
                List<string> genres = movie.MovieDetails.Genre.Split(',').ToList();
                allGenres.AddRange(genres);
            }
            CategoriesList = new ObservableCollection<string>(allGenres.Distinct());

        }
        #endregion
        #region TicketPages
        public async Task GetUserTickets()
        {
            string userRefId = "";
            if (LoggedUser?.UserRefId != null)
                userRefId = LoggedUser.UserRefId;
            else
                userRefId = await AppPreferences.GetString("UserId");

            if (userRefId == null)
                return;

            if (LoggedUser != null)
                OriginalTicketList = await Firebase.Firebase.GetTicketByUserRefId(LoggedUser.UserRefId);

            ClaimTicketLists = new ObservableCollection<TicketVM>(GetActiveTickets());
            ReviewTicketLists = new ObservableCollection<TicketVM>(GetWaitingReviewTickets());
            ExpiredTicketLists = new ObservableCollection<TicketVM>(GetExpiredTickets());
        }
        public void ClearAllTickets()
        {
            OriginalTicketList = null;
            ClaimTicketLists = null;
            ReviewTicketLists = null;
            ExpiredTicketLists = null;
        }
        public List<TicketVM> GetActiveTickets()
        {
            var list = OriginalTicketList.Where(c => c.Status == "Active" || c.Status == "OnShowing" || c.Status == "Claimed")
                .OrderBy(c => ParseDateTime(c.Date, c.Time))
                .ToList();
            ClaimTicketCount = list.Count > 0 ? list.Count.ToString() : null;

            ClaimCurrentCount = list.Count <= 5 ? list.Count : 5;
            if (list.Count > 5)
                ClaimLoadMoreVisible = true;
            return list.Take(ClaimCurrentCount).ToList();
        }
        public List<TicketVM> GetExpiredTickets()
        {
            var list = OriginalTicketList.Where(c => c.Status == "Expired" || c.Status == "Complete")
                .OrderByDescending(c => ParseDateTime(c.Date, c.Time))
                .ToList();
            ExpiredTicketCount = list.Count > 0 ? list.Count.ToString() : null;

            ExpiredCurrentCount = list.Count <= 5 ? list.Count : 5;

            if (list.Count > 5)
                ExpiredLoadMoreVisible = true;
            return list.Take(ExpiredCurrentCount).ToList();
        }
        public List<TicketVM> GetWaitingReviewTickets()
        {
            var list = OriginalTicketList.Where(c => c.Status == "WaitingForReview")
                .OrderBy(c => ParseDateTime(c.Date, c.Time))
                .ToList();

            ReviewTicketCount = list.Count > 0 ? list.Count.ToString() : null;
            ReviewCurrentCount = list.Count <= 5 ? list.Count : 5;

            if (list.Count > 5)
                ReviewLoadMoreVisible = true;
            return list.Take(ReviewCurrentCount).ToList();
        }
        public TicketVM GetSelectedTicket(string ticketId)
        {
            TicketVM find = ClaimTicketLists.FirstOrDefault(ticket => ticket.TicketId == ticketId);
            return find;
        }
        public void LoadMoreActiveTicket()
        {
            var list = OriginalTicketList.Where(c => c.Status == "Active" || c.Status == "OnShowing" || c.Status == "Claimed")
          .OrderBy(c => ParseDateTime(c.Date, c.Time))
          .ToList();
            int maxCount = list.Count;
            int takeFrom = ClaimCurrentCount;
            int takeCount = maxCount - takeFrom > 5 ? 5 : maxCount - takeFrom;

            var takeList = list.Skip(takeFrom).Take(takeCount).ToList();

            ClaimCurrentCount = takeFrom + takeCount;
            ClaimLoadMoreVisible = maxCount - ClaimCurrentCount > 0;
            foreach (var item in takeList)
            {
                ClaimTicketLists.Add(item);
            }

        }

        public void LoadMoreReviewTicket()
        {
            var list = OriginalTicketList.Where(c => c.Status == "WaitingForReview")
                                           .OrderBy(c => ParseDateTime(c.Date, c.Time))
                                           .ToList();
            int maxCount = list.Count;
            int takeFrom = ReviewCurrentCount;
            int takeCount = maxCount - takeFrom > 5 ? 5 : maxCount - takeFrom;

            var takeList = list.Skip(takeFrom).Take(takeCount).ToList();

            ReviewCurrentCount = takeFrom + takeCount;
            ReviewLoadMoreVisible = maxCount - ReviewCurrentCount > 0;
            foreach (var item in takeList)
            {
                ReviewTicketLists.Add(item);
            }
        }
        public void LoadMoreExpiredTicket()
        {
            var list = OriginalTicketList.Where(c => c.Status == "Expired" || c.Status == "Complete")
                               .OrderBy(c => ParseDateTime(c.Date, c.Time))
                               .ToList();
            int maxCount = list.Count;
            int takeFrom = ExpiredCurrentCount;
            int takeCount = maxCount - takeFrom > 5 ? 5 : maxCount - takeFrom;

            var takeList = list.Skip(takeFrom).Take(takeCount).ToList();

            ExpiredCurrentCount = takeFrom + takeCount;
            ExpiredLoadMoreVisible = maxCount - ExpiredCurrentCount > 0;
            foreach (var item in takeList)
            {
                ExpiredTicketLists.Add(item);
            }
        }
        private DateTime ParseDateTime(string date, string time)
        {
            string dateTimeString = $"{date} {time}";
            DateTime dateTime = DateTime.Parse(dateTimeString);
            return dateTime;

        }
        private List<TicketVM> OriginalTicketList;

        private ObservableCollection<TicketVM> claimTicketLists;
        public ObservableCollection<TicketVM> ClaimTicketLists
        {
            get => claimTicketLists;
            set => SetProperty(ref claimTicketLists, value);
        }
        private ObservableCollection<TicketVM> reviewTicketLists;
        public ObservableCollection<TicketVM> ReviewTicketLists
        {
            get => reviewTicketLists;
            set => SetProperty(ref reviewTicketLists, value);
        }
        private string reviewTicketCount;
        public string ReviewTicketCount
        {
            get => reviewTicketCount;
            set => SetProperty(ref reviewTicketCount, value);
        }
        private string claimTicketCount;
        public string ClaimTicketCount
        {
            get => claimTicketCount;
            set => SetProperty(ref claimTicketCount, value);
        }
        private string expiredTicketCount;
        public string ExpiredTicketCount
        {
            get => expiredTicketCount;
            set => SetProperty(ref expiredTicketCount, value);
        }

        private int ReviewCurrentCount = 0;

        private int ClaimCurrentCount = 0;

        private int ExpiredCurrentCount = 0;
        private bool reviewLoadMoreVisibile = false;
        private bool claimLoadMoreVisibile = false;
        private bool expiredLoadMoreVisibile = false;
        public bool ReviewLoadMoreVisible
        {
            get => reviewLoadMoreVisibile;
            set => SetProperty(ref reviewLoadMoreVisibile, value);
        }
        public bool ClaimLoadMoreVisible
        {
            get => claimLoadMoreVisibile;
            set => SetProperty(ref claimLoadMoreVisibile, value);
        }
        public bool ExpiredLoadMoreVisible
        {
            get => expiredLoadMoreVisibile;
            set => SetProperty(ref expiredLoadMoreVisibile, value);
        }

        private ObservableCollection<TicketVM> expiredTicketLists;
        public ObservableCollection<TicketVM> ExpiredTicketLists
        {
            get => expiredTicketLists;
            set => SetProperty(ref expiredTicketLists, value);
        }
        private bool isTicketLoading = false;
        public bool IsTicketLoading
        {
            get => isTicketLoading;
            set => SetProperty(ref isTicketLoading, value);
        }
        #endregion

    }



}
