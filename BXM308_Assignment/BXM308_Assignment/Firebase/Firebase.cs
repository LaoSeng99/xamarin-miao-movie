using BXM308_Assignment.Model;
using BXM308_Assignment.ViewModels;
using Firebase.Database;
using Firebase.Database.Query;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Internals;

namespace BXM308_Assignment.Firebase
{
    public class Firebase
    {
        public static FirebaseClient firebase = new FirebaseClient("https://bxm308assignment-default-rtdb.asia-southeast1.firebasedatabase.app/");

        #region User Register
        public static async Task<bool> CheckEmailExist(string email)
        {
            while (true)
            {
                try
                {
                    var checkEmail = await firebase.Child("UserTable").OrderBy("Email").EqualTo(email).OnceAsync<User>();
                    return checkEmail.Count != 0;
                }
                catch
                {
                    continue;
                }
            }
        }
        public static async Task<UserVM> GetUserByFirebaseKey(string key)
        {
            while (true)
            {
                try
                {
                    var user = await firebase.Child("UserTable").Child(key).OnceSingleAsync<UserVM>();
                    user.UserRefId = key;
                    return user;
                }
                catch
                {
                    continue;
                }
            }
        }
        public static async Task<UserVM> LogIn(string email, string password)
        {
            while (true)
            {
                try
                {
                    var user = (await firebase.Child("UserTable").OrderBy("Email").EqualTo(email).OnceAsync<UserVM>())
                        .Select(item =>
                        {
                            var userVM = item.Object;
                            userVM.UserRefId = item.Key;
                            return userVM;
                        })
                        .FirstOrDefault();
                    if (user == null)
                        return null;
                    if (user.Password != password)
                        return null;

                    return user;
                }
                catch
                {
                    continue;
                }
            }
        }
        public static async Task RegisterNewUser(User user)
        {
            await firebase.Child("UserTable").PostAsync(user);
        }
        #endregion
        #region Movie Show

        public static async Task<List<RoomTime>> GetAllRoomTime()
        {
            var table = (await firebase.Child("RoomTimeTable").OnceAsync<RoomTime>())
                     .Select(item =>
                     {
                         var roomTime = item.Object;

                         if (string.IsNullOrEmpty(roomTime.RefId))
                             roomTime.RefId = item.Key;
                         return roomTime;
                     }).ToList();
            //var table = await firebase.Child("RoomTimeTable").OrderBy("Date").EqualTo("21 Sep 2023").OnceAsync<RoomTime>();
            //List<RoomTime> result = table.Object;
            return table;
        }
        public static async Task<List<RoomTime>> GetRoomTimeByMovieIdAndDate(string movieId, string date)
        {
            var now = DateTime.UtcNow.AddHours(8);

            List<RoomTime> timeList;
            var roomTimes = await firebase.Child("RoomTimeTable")
                        .OrderBy("Date")
                        .EqualTo(date)
                        .OnceAsync<RoomTime>();
            if (DateTime.Parse(date) == now.Date)
                timeList = roomTimes.Where(c => c.Object.MovieId == movieId)
                                    .Where(item => DateTime.Parse(item.Object.Time) > now)
                                    .Select(item =>
                                    {
                                        var roomTime = item.Object;
                                        roomTime.RefId = item.Key;
                                        return roomTime;
                                    })
                                   .ToList();
            else
                timeList = roomTimes.Where(c => c.Object.MovieId == movieId)
                                   .Select(item =>
                                   {
                                       var roomTime = item.Object;
                                       roomTime.RefId = item.Key;
                                       return roomTime;
                                   })
                                  .ToList();


            return timeList;
        }
        public static async Task<RoomSeatContainer> GetRoomSeatByTimeRefId(string refId)
        {
            while (true)
            {
                try
                {
                    var roomSeatList = await firebase.Child("RoomSeatTable").OrderBy("TimeRefId").EqualTo(refId).OnceAsync<RoomSeatContainer>();
                    List<RoomSeatContainer> roomSeatContainers = roomSeatList
                        .Select(item =>
                      {
                          var seat = item.Object;
                          seat.RefId = item.Key;
                          return seat;
                      }
                    ).ToList();
                    return roomSeatContainers.First();
                }
                catch
                {
                    continue;
                }
            }

        }


        public static async Task Delete()
        {
            var table = firebase.Child("RoomTable");
            await table.DeleteAsync();
            var RoomSeatTable = firebase.Child("RoomSeatTable");
            await RoomSeatTable.DeleteAsync();
            var RoomTimeTable = firebase.Child("RoomTimeTable");
            await RoomTimeTable.DeleteAsync();
        }



        //Automation
        public static async Task AddNewRoom(int roomId)
        {
            Room room = new Room()
            {
                Id = $"Room-{roomId:D5}",
                CreateTime = DateTime.UtcNow.AddHours(8).ToString("dd-MM-yyyy HH:mm:ss"),

            };

            await firebase.Child("RoomTable").PostAsync(room);
        }
        public static async Task AddNewRoomTime(RoomTime roomTime)
        {
            while (true)
            {
                try
                {
                    await firebase.Child("RoomTimeTable").PostAsync(roomTime);
                    break;
                }
                catch
                {
                    continue;
                }
            }
        }
        public static async Task AddNewSeat(RoomSeatContainer room)
        {
            while (true)
            {
                try
                {
                    await firebase.Child("RoomSeatTable").PostAsync(room);
                    break;
                }
                catch
                {
                    continue;
                }
            }
        }

        //End
        #endregion
        #region Bookinig Ticket
        public static async Task AddNewTicket(Ticket ticket)
        {
            while (true)
            {
                try
                {
                    await firebase.Child("TicketTable").PostAsync(ticket);
                    break;
                }
                catch
                {
                    continue;
                }
            }
        }
        public static async Task UpdateRoomTime(RoomTime room)
        {
            while (true)
            {
                try
                {
                    await firebase.Child("RoomTimeTable").Child(room.RefId).PutAsync(room);
                    break;
                }
                catch
                {
                    continue;
                }
            }


        }
        public static async Task UpdateSeat(RoomSeatContainerVM roomSeat)
        {
            while (true)
            {
                try
                {
                    await firebase.Child("RoomSeatTable").Child(roomSeat.RefId).PutAsync(roomSeat);
                    break;
                }
                catch
                {
                    continue;
                }
            }
        }
        #endregion
        #region Get Ticket By UserId
        public static async Task<List<TicketVM>> GetTicketByUserRefId(string refId)
        {
            while (true)
            {
                try
                {
                    var ticketTable = await firebase.Child("TicketTable").OrderBy("UserId").EqualTo(refId).OnceAsync<TicketVM>();
                    List<TicketVM> ticketList = ticketTable
                        .Select(item =>
                        {
                            if (string.IsNullOrEmpty(item.Object.TicketId))
                                item.Object.TicketId = item.Key;


                            DateTime ticketDateTime = DateTime.Parse($"{item.Object.Date} {item.Object.Time}");
                            DateTime ticketEndTime = ticketDateTime.AddMinutes(item.Object.MovieDuration.TotalMinutes + 15);

                            var now = DateTime.UtcNow.AddHours(8);
                            var currentStatus = item.Object.Status;
                            if (now >= ticketDateTime && now <= ticketEndTime)
                                item.Object.Status = "OnShowing";
                            else if (now > ticketEndTime && item.Object.Status == "Active")
                                item.Object.Status = "Expired";
                            else if (now >= ticketEndTime && item.Object.Status == "Active" || item.Object.Status == "OnShowing")
                                item.Object.Status = "WaitingForReview";
                            else if (item.Object.Status == "Claimed" && now >= ticketEndTime)
                                item.Object.Status = "WaitingForReview";
                            if (currentStatus != item.Object.Status)
                                firebase.Child("TicketTable").Child(item.Key).PutAsync(item.Object);


                            return item.Object;

                        }
                    ).ToList();

                    //_ = UpdateTicket(ticketList);
                    return ticketList;
                }
                catch (Exception ex)
                {
                    continue;
                }
            }

        }

        public static async Task UpdateTicket(List<TicketVM> ticket)
        {
            int maxAttempts = 3;
            int attempts = 0;

            while (attempts < maxAttempts)
            {
                try
                {
                    foreach (var ticketVM in ticket)
                    {
                        await firebase.Child("TicketTable").Child(ticketVM.TicketId).PutAsync(ticketVM);
                    }

                    break;
                }
                catch
                {
                    attempts++;
                    await Task.Delay(200);
                    continue;
                }
            }
        }
        #endregion
        public static async Task<DateTime> GetLastUpdate()
        {
            var timeRecord = await firebase
             .Child("LastLoadTimeTable")
             .Child("TimeField")
             .OnceSingleAsync<DateTime?>();

            if (timeRecord == null)
            {
                var currentTime = DateTime.UtcNow;
                await SetLastLoadTimeAsync(currentTime);
                return currentTime;
            }

            return timeRecord.Value;
        }

        public static async Task UpdateLastLoadTimeAsync(DateTime newTime)
        {
            await firebase
              .Child("LastLoadTimeTable")
              .Child("TimeField")
                  .PutAsync(newTime);
        }

        public static async Task SetLastLoadTimeAsync(DateTime time)
        {
            await firebase
            .Child("LastLoadTimeTable")
            .Child("TimeField")
               .PutAsync(time);
        }
    }
}
