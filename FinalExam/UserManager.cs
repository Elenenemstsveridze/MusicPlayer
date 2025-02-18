using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{

    public class UserManager
    {
        private const string FilePath = "MusicPlaylistUsers.txt";

        public delegate void SignUpSuccessEventHandler(string username);
        public delegate void SignInSuccessEventHandler(string username);

        public static event SignUpSuccessEventHandler SignUpSuccess;
        public static event SignInSuccessEventHandler SignInSuccess;

        public static bool SignUp(string username, string password, string confirmPassword)
        {
            try
            {
                if (password != confirmPassword)
                {
                    MessageBox.Show("Passwords do not match.", "Sign-Up Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
                {
                    MessageBox.Show("All fields are required and cannot contain only whitespace.", "Sign-Up Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (File.Exists(FilePath))
                {
                    string[] existingUsers = File.ReadAllLines(FilePath);
                    foreach (string line in existingUsers)
                    {
                        if (line.StartsWith(username + ":"))
                        {
                            MessageBox.Show("Username already exists.", "Sign-Up Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }

                using (StreamWriter sw = File.AppendText(FilePath))
                {
                    sw.WriteLine($"{username}:{password}");
                }

                SignUpSuccess?.Invoke(username);

                return true;
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Error while accessing the file: {ex.Message}", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Sign-Up Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool SignIn(string username, string password)
        {
            try
            {
                if (!File.Exists(FilePath))
                {
                    MessageBox.Show("No users have been registered.", "Sign-In Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("All fields are required and cannot contain only whitespace.", "Sign-In Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                string[] users = File.ReadAllLines(FilePath);
                foreach (string line in users)
                {
                    string[] userData = line.Split(':');
                    if (userData[0] == username && userData[1] == password)
                    {
                        SignInSuccess?.Invoke(username);

                        return true;
                    }
                }

                MessageBox.Show("Invalid username or password.", "Sign-In Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Error while accessing the file: {ex.Message}", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Sign-In Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}

