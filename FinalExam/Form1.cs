namespace FinalExam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UserManager.SignUpSuccess += OnSignUpSuccess;
            UserManager.SignInSuccess += OnSignInSuccess;

        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            string username = UsernameSignUpTxt.Text;
            string password = PasswordSignUpTxt.Text;
            string confirmPassword = ConfirmPasswordTxt.Text;

            bool success = UserManager.SignUp(username, password, confirmPassword);
            if (success)
            {
                ClearInputs();
            }

        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            string username = UsernameSignInTxt.Text;
            string password = PasswordSignInTxt.Text;

            bool success = UserManager.SignIn(username, password);
            if (success)
            {
                PlaylistForm playlistForm = new PlaylistForm();
                playlistForm.Show();
                this.Hide();
            }
        }

        private void OnSignUpSuccess(string username)
        {
            MessageBox.Show($"User {username} signed up successfully!");
        }

        private void OnSignInSuccess(string username)
        {
            MessageBox.Show($"User {username} signed in successfully!");
        }

        private void ClearInputs()
        {
            UsernameSignUpTxt.Clear();
            PasswordSignUpTxt.Clear();
            ConfirmPasswordTxt.Clear();

        }
    }
}
