Movie Ticket App
This is a student assignment project that automates the creation of movie shows and seating arrangements using Firebase Realtime Database. It demonstrates a simple movie ticket management system, including room creation, showtime scheduling, and seat allocation.

# Features
- Room Creation: Automatically generate rooms in the database.
- Showtimes Scheduling: Create movie showtimes for the next 14 days with random time slots.
- Seat Arrangement: Assign seating arrangements for each showtime.
- User Registration: Register new users with Firebase.
- Browse Movies: Allow users to browse available movies and showtimes.
- Firebase Integration: All data is saved and managed in Firebase Realtime Database.

## 1. Prerequisites
Before you begin, ensure you have the following:
- Xamarin.Forms development environment.
- Firebase Realtime Database account.
  
## 2. Firebase Realtime Database Setup
To use the app with Firebase Realtime Database, follow these steps:

### Create a Firebase Project:
1. Go to Firebase Console.
2. Create a new project and enable Firebase Realtime Database.
3. Set Firebase Realtime Database Rules: If you are just testing the app without authentication, set the following rules to allow read and write access:

```
{
  "rules": {
    ".read": "auth == null",
    ".write": "auth == null"
  }
}
```
> OR, if you're using authentication, configure your rules accordingly.

Database Indexing Rules: Add the following indexing rules to optimize database queries:
```
{
  "rules": {
    "RoomTimeTable": { ".indexOn": ["Date"] },
    "RoomSeatTable": { ".indexOn": ["TimeRefId"] },
    "UserTable": { ".indexOn": ["UserRefId", "Phone", "Id", "Email"] },
    "TicketTable": { ".indexOn": ["UserId"] }
  }
}
```

# Installation
## 1. Clone the Repository
```
git clone https://github.com/LaoSeng99/xamarin-miao-movie.git
```
## 2. Set Firebase Realtime Database URL
Open the project file at /Firebase/Firebase/Firebase.cs.

Replace the Firebase URL placeholder with your Firebase Realtime Database URL:
```
public static FirebaseClient firebase = new FirebaseClient("https://{your-firebase-project}.firebasedatabase.app");
```

## 3. Firebase Authentication (Optional)
If you have set up Firebase Authentication, complete the authentication setup in the project:

Integrate Firebase Auth in the /Firebase/FirebaseAuth.cs file.

Follow the official [Firebase Authentication documentation](https://firebase.google.com/docs/auth) to configure your authentication methods.

### Usage
- Running the Project
- Open the project in Visual Studio.
- Build and run the project on your emulator or physical device.
- App Functionality
- Room Creation: Automatically create rooms in the database.
- Showtimes Scheduling: Generate movie showtimes for the next 14 days, with random time slots.
- Seat Arrangement: Assign seats for each showtime.
- Firebase Integration: All data is saved and retrieved from Firebase Realtime Database.
Troubleshooting
Common Issues
Firebase URL Error: Ensure that you correctly replace the Firebase URL in the /Firebase/Firebase/Firebase.cs file.
Database Rules Error: Make sure the Firebase Realtime Database rules are set correctly, as shown above.
Authentication Issues: If using Firebase Auth, ensure proper configuration by following Firebase’s documentation.
Contributing
Feel free to fork this repository, submit issues, or create pull requests. All contributions are welcome!

License
This project is open-source under the MIT License.

Support
For any questions or help, please reach out by creating an issue on the GitHub repository.

4. Note to Users
If you are trying this app for testing purposes, please make sure to update your Firebase database rules as follows:

```
{
  "rules": {
    ".read": "auth == null",
    ".write": "auth == null"
  }
}
```

This will allow you to use the app without setting up Firebase Authentication. However, for production use, it is strongly recommended to configure proper authentication and security rules in Firebase.
