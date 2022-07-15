using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Windows.Forms;

namespace WinFormsApp
{


    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ShowLoginOnlyMenu();
        }
     
        private void LoginButton_Click_1(object sender, EventArgs e)
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44317/");
            UserModelForm user = new() { UserName = UserInputBox.Text, Password = PasswordInputBox.Text };
            var response = client.PostAsJsonAsync("/api/user/Log in", user).Result;
            var result = response.Content.ReadAsStringAsync();
            globalToken = result.Result.ToString();
            globalUserName = UserInputBox.Text;
            UsernameTextBox.Text = globalUserName;
            ShowLogedUserMenu();
        }
        private void AddUserButton_Click(object sender, EventArgs e)
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44317/");
            UserModelForm user = new() { UserName = UserInputBox.Text, Password = PasswordInputBox.Text };
            var response = client.PostAsJsonAsync("/api/user/Create User", user).Result;
            var result = response.Content.ReadAsStringAsync();
            globalToken = result.Result.ToString();
            ShowLogedUserMenu();
            globalUserName = UserInputBox.Text;
            UsernameTextBox.Text = globalUserName;
        }

        private void AddNoteButton_Click(object sender, EventArgs e)
        {
            AddNote note = new();
            note.Show();
        }
        private void AddCategoryButton_Click(object sender, EventArgs e)
        {
            AddCastegory addCastegory = new();
            addCastegory.Show();
        }
     
        private void ShowLogedUserMenu()
        {
            UsernameTextBox.Hide();
            UserInputBox.Hide();
            PasswordInputBox.Hide();
            PaswordLabel.Hide();
            LoginButton.Hide();
            AddUserButton.Hide();
            label1.Hide();
            AddCategoryButton.Show();
            AddNoteButton.Show();
            EditButton.Show();
            RemoveButton.Show();
            LogoutButton.Show();
            UsernameTextBox.Show();
            dataGridView1.Show();
            
        }

        private void ShowLoginOnlyMenu()
        {
            UsernameTextBox.Show();
            UserInputBox.Show();
            PasswordInputBox.Show();
            PaswordLabel.Show();
            LoginButton.Show();
            AddUserButton.Show();
            WelcomeLabel.Hide();
            AddCategoryButton.Hide();
            AddNoteButton.Hide();
            EditButton.Hide();
            RemoveButton.Hide();
            LogoutButton.Hide();
            UsernameTextBox.Hide();
            dataGridView1.Hide();

        }
        public static string globalToken = "";
        public static string globalUserName = "";

  
    }
}
