using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class MainForm : Form
    {
        private string _username, _password;

        public string Username { get { return _username = UserInputBox.Text; } set { _username= value; } }
        public string Password { get { return _password = PasswordInputBox.Text; } set { _password = value; } }

        private class LoginClass
        {
            public string UserName, Password;
        }

        public MainForm()
        {
            InitializeComponent();
            HideLogedUserMenuButtons();
        }

        private void LoginButton_Click_1(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44317/");
                LoginClass lgn = new LoginClass { UserName = UserInputBox.Text, Password = PasswordInputBox.Text };
                var response = client.PostAsJsonAsync("/api/user/Log in", lgn).Result;
                response.Content.ReadAsStringAsync();
                ShowLogedUserMenuButtons();
            }
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44317/");
                LoginClass lgn = new LoginClass { UserName = UserInputBox.Text, Password = PasswordInputBox.Text };
                var response = client.PostAsJsonAsync("/api/user/Create User", lgn).Result;
                response.Content.ReadAsStringAsync();
                HideLogedUserMenuButtons();
            }
        }

        private void HideLogedUserMenuButtons()
        {
            AddCategoryButton.Hide();
            AddNoteButton.Hide();
            EditButton.Hide();
            RemoveButton.Hide();
            LogoutButton.Hide();
            UsernameTextBox.Hide();
            WelcomeLabel.Hide();
            dataGridView1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowLogedUserMenuButtons()
        {
            AddCategoryButton.Show();
            AddNoteButton.Show();
            EditButton.Show();
            RemoveButton.Show();
            LogoutButton.Show();
            UsernameTextBox.Show();
            WelcomeLabel.Show();
            dataGridView1.Show();
            LoginButton.Hide();
            AddUserButton.Hide();
            PasswordInputBox.Hide();
            UserInputBox.Hide();
            UserLabel.Hide();
            PaswordLabel.Hide();
        }
    }
}
