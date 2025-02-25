MusicPlayer 🎵
A C# Windows Forms Application for Music Playback.

This is my first C# project, created during my first semester as part of a final exam. It is a Windows Forms application that allows users to sign up, log in, manage playlists, and play music from a locally stored collection.

📌 Overview
The project consists of four different forms representing different stages of user interaction:
1. Authentication (Form1) – User sign-up and sign-in system.
2. Playlist Management – Displays all available music and allows users to organize their playlists.
3. Song Filtering & Selection – Includes a filtering system and lets users add songs to playlists.
4. Music Playback (PlaySongForm) – Controls for playing, pausing, and navigating between songs.

🎯 Features
✔ User Authentication – Sign-up and sign-in system with credentials stored in a text file.
✔ Playlist Management – Users can create playlists and add music from the available collection.
✔ Music Playback – Play, pause, and skip through songs.
✔ Filtering System – Allows users to filter songs within playlists.
✔ Local Resource Storage – Songs, JSON metadata, and images are stored in the Resources folder.

🛠️ Technologies Used
✧ C# – Core programming language.
✧ Windows Forms (WinForms) – UI framework for building the application.
✧ JSON – Used to store and load music data.
✧ Text File Storage – Used to store user credentials.

📂 Project Structure
🔹 Prompt Class (Custom Dialog Box) - The Prompt class is a custom pop-up window used for receiving user input.
    Displays an input dialog for user prompts.
🔹 Song Class (Music Data Model) - The Song class represents a music track, containing its name, file path, image, and associated playlists.
    Stores metadata for each song, loaded from a JSON file.
🔹 SongsData Class (Playlist Management) - The SongsData class manages a collection of Song objects, representing the full music library.
    Handles loading and storing music data in JSON format.
🔹 UserManager Class (Authentication System) - The UserManager class manages user registration and login authentication. It reads and writes user credentials to a text file.
    Handles sign-up and sign-in logic.
    Stores user credentials in a text file.
    Checks for duplicate usernames.
    Validates user input fields.

✨ Final Thoughts
This project was a great learning experience in C#, Windows Forms, and file handling. While simple, it helped me understand UI development, authentication, and JSON data storage.
