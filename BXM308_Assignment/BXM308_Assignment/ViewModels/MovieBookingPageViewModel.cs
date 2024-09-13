using BXM308_Assignment.Firebase;
using BXM308_Assignment.Model;
using BXM308_Assignment.PageViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace BXM308_Assignment.ViewModels
{
    public class MovieBookingPageViewModel : BaseViewModel
    {
        public MovieBookingPageViewModel(MovieViewModel movie)
        {
            Movie = movie;
        }
        protected override async void OnLoadCommandExecute()
        {
            if (IsDataLoad)
                return;

            var dateList = new ObservableCollection<DateClass>();
            bool[] dateStatus = { true, false, true, true };
            Random random = new Random();
            //Room Ticker was added till OCT 3, After OCT 3, no show anymore
            DateTime today = DateTime.Now;
            DateTime endOfMonth = new DateTime(today.Year, 10, 3);

            int days = (endOfMonth - today).Days;
            for (int i = 0; i <= days + 1; i++)
            {
                DateTime currentDay = today.AddDays(i);
                dateList.Add(new DateClass()
                {
                    Id = currentDay.Day.ToString($"0_{i}"),
                    Day = currentDay.Day.ToString(),
                    Month = currentDay.ToString("MMM", new CultureInfo("en-US")).ToUpper(),
                    IsAvailable = true
                });
            }
            dateList.First().Status = "Selected";


            bool isSuccess = await GetRoomTimeShowByDate(DateTime.UtcNow.AddHours(8).ToString("dd MMM yyyy", new CultureInfo("en-US")));
            DateList = dateList;
            IsDataLoad = true;

            if (!isSuccess)
            {
                //MessagingCenter.Send<App>((App)Application.Current, "NoMovieTime");
                IsAvailable = false;
                return;
            }


        }
        //========== Get Data =============
        private async Task<bool> GetRoomTimeShowByDate(string date)
        {
            IsAvailable = true;
            var roomTimes = await Firebase.Firebase.GetRoomTimeByMovieIdAndDate(Movie.Id, date);
            if (roomTimes == null || roomTimes.Count == 0)
                return false;

            var allTimeShows = roomTimes.Where(c => c.MovieId == Movie.Id)
                           .OrderBy(c => DateTime.ParseExact(c.Time, "h:mm tt", CultureInfo.InvariantCulture))
                           .GroupBy(c => c.Time).Select(group => group.First())
                           .ToList();
            var roomSeat = await Firebase.Firebase.GetRoomSeatByTimeRefId(allTimeShows.First().RefId);
            RoomSeatContainerVM roomSeatC = new RoomSeatContainerVM()
            {
                RefId = roomSeat.RefId,
                RoomSeatList = roomSeat.RoomSeatList,
                SeatLists = roomSeat.RoomSeatList,
                TimeRefId = roomSeat.TimeRefId
            };

            foreach (var time in allTimeShows)
            {
                if (time.IsFull)
                {
                    time.Status = "Unavailable";
                    continue;
                }
            }

            allTimeShows.First().Status = "Selected";

            RoomSeat = roomSeatC;
            SelectedDateTime = new ObservableCollection<RoomTime>(allTimeShows.ToList());

            return true;
        }
        public async Task<bool> UpdateSelectedDateTime(string dateId)
        {
            var sameDate = DateList.FirstOrDefault(c => c.Status == "Selected" && c.Id == dateId);
            if (sameDate != null)
                return false;

            ClearAllSelectedSeat();
            if (SelectedDateTime != null)
                SelectedDateTime.Clear();
            if (RoomSeat.SeatLists != null)
                RoomSeat.SeatLists.Clear();

            var currentDate = DateList.FirstOrDefault(c => c.Status == "Selected");
            var selectedDate = DateList.FirstOrDefault(c => c.Id == dateId);
            currentDate.Status = currentDate.IsAvailable ? "Available" : "Unavailable";
            selectedDate.Status = "Selected";

            var date = new DateTime(DateTime.Now.Year, monthMappings[selectedDate.Month], int.Parse(selectedDate.Day));
            var result = await GetRoomTimeShowByDate(date.ToString("dd MMM yyyy", new CultureInfo("en-US")));
            if (!result)
                IsAvailable = false;
            return true;

        }
        public async Task<bool> UpdateSelectedTimeSeat(string time)
        {
            var sameTime = SelectedDateTime.FirstOrDefault(c => c.Status == "Selected" && c.Time == time);
            if (sameTime != null)
                return false;

            ClearAllSelectedSeat();
            RoomSeat.SeatLists.Clear();
            var currentTime = SelectedDateTime.FirstOrDefault(c => c.Status == "Selected");
            var selectedTime = SelectedDateTime.FirstOrDefault(c => c.Time == time);
            currentTime.Status = currentTime.IsFull ? "Unavailable" : "Available";
            selectedTime.Status = "Selected";


            var roomSeat = await Firebase.Firebase.GetRoomSeatByTimeRefId(selectedTime.RefId);
            RoomSeatContainerVM roomSeatC = new RoomSeatContainerVM()
            {
                RefId = roomSeat.RefId,
                RoomSeatList = roomSeat.RoomSeatList,
                SeatLists = roomSeat.RoomSeatList,
                TimeRefId = roomSeat.TimeRefId
            };
            RoomSeat = roomSeatC;

            return true;

        }
        public async Task<TicketVM> GenerateTicket()
        {
            Random random = new Random();
            var userId = await AppPreferences.GetString("UserId");
            var selectedRoomTime = SelectedDateTime.FirstOrDefault(c => c.Status == "Selected");

            TicketVM ticket = new TicketVM()
            {
                Id = $"MiaoTicket-{random.Next(1, 999999):D6}-{random.Next(1, 999):D3}",
                TicketId = "",
                ReservationCode = string.Join(", ", SeatCodeList.OrderBy(c => c)),
                ReservaSeatNumber = SeatCodeList.Count,
                IsPaid = false,
                Status = "Pending Payment",
                UserId = userId,
                RoomTimeRefId = selectedRoomTime.RefId,
                Date = selectedRoomTime.Date,
                Time = selectedRoomTime.Time,
                MovieId = Movie.Id,
                MoviePoster = Movie.Poster,
                MovieTitle = Movie.MovieDetails.Title,
                MovieDuration = Movie.MovieDetails.Duration,
                TotalAmount = (Movie.Price * SeatCodeList.Count),
                CreatedTime = DateTime.UtcNow.AddHours(8),
                RoomId = selectedRoomTime.RoomId,

            };
            return ticket;
        }
        public RoomTime GetSelectedTimeRoom()
        {
            var find = SelectedDateTime.FirstOrDefault(c => c.Status == "Selected");
            return find;
        }
        public RoomSeatContainerVM GetSelectedSeat()
        {

            return RoomSeat;
        }
        //========== Navigate Page ===============
        //========== Function Method ===========
        public void UpdateSelectedSeat(string seatCode)
        {
            var timeSeat = SelectedDateTime.FirstOrDefault(c => c.Status == "Selected");

            var selectedSeat = RoomSeat.SeatLists.FirstOrDefault(c => c.Code == seatCode);
            if (selectedSeat.Status == "Available")
            {
                ReviewButtonText = "Review & Payment >";
                SeatCodeList.Add(seatCode);
                NumOfSeat++;
                SeatTotalPrice = (NumOfSeat * Movie.Price).ToString("RM #,##0.00", new CultureInfo("ms-MY"));
                selectedSeat.Status = "Selected";
                return;
            }

            selectedSeat.Status = "Available";
            NumOfSeat--;
            SeatCodeList.Remove(seatCode);
            SeatTotalPrice = (NumOfSeat * Movie.Price).ToString("RM #,##0.00", new CultureInfo("ms-MY"));
            if (NumOfSeat == 0)
                ReviewButtonText = "Select a seat >";
            return;
        }
        public void ClearAllSelectedSeat()
        {
            NumOfSeat = 0;
            SeatTotalPrice = "RM 0.00";
            if (RoomSeat?.SeatLists != null)
                RoomSeat.SeatLists.Where(c => c.Status == "Selected").ForEach(c => c.Status = "Available");
            if (SeatCodeList != null)
                SeatCodeList.Clear();
            ReviewButtonText = "Select a seat >";
        }
        //========== Object/Bool Area =============
        //private
        private string reviewButtonText = "Select a seat >";
        private string seatTotalPrice = "RM 0.00";
        private int numOfSeat = 0;
        private bool IsDataLoad = false;
        private bool isAvailable = false;
        private MovieViewModel movie;
        private RoomSeatContainerVM roomSeat = new RoomSeatContainerVM();
        private ObservableCollection<RoomTime> selectedDateTime;
        private ObservableCollection<DateClass> dateList = new ObservableCollection<DateClass>();
        private ObservableCollection<string> seatCodeList = new ObservableCollection<string>();
        Dictionary<string, int> monthMappings = new Dictionary<string, int>
        {
            {"JAN", 1},
            {"FEB", 2},
            {"MAR", 3},
            {"APR", 4},
            {"MAY", 5},
            {"JUN", 6},
            {"JUL", 7},
            {"AUG", 8},
            {"SEP", 9},
            {"OCT", 10},
            {"NOV", 11},
            {"DEC", 12}
        };
        //public
        public bool IsAvailable
        {
            get => isAvailable;
            set => SetProperty(ref isAvailable, value);
        }
        public int NumOfSeat
        {
            get => numOfSeat;
            set => SetProperty(ref numOfSeat, value);
        }
        public string ReviewButtonText
        {
            get => reviewButtonText;
            set => SetProperty(ref reviewButtonText, value);
        }
        public string SeatTotalPrice
        {
            get => seatTotalPrice;
            set => SetProperty(ref seatTotalPrice, value);
        }
        public MovieViewModel Movie
        {
            get => movie;
            set => SetProperty(ref movie, value);
        }
        public RoomSeatContainerVM RoomSeat
        {
            get => roomSeat;
            set => SetProperty(ref roomSeat, value);
        }
        public ObservableCollection<string> SeatCodeList
        {
            get => seatCodeList;
            set => SetProperty(ref seatCodeList, value);
        }
        public ObservableCollection<RoomTime> SelectedDateTime
        {
            get => selectedDateTime;
            set => SetProperty(ref selectedDateTime, value);
        }
        public ObservableCollection<DateClass> DateList
        {
            get => dateList;
            set => SetProperty(ref dateList, value);
        }
    }
}
