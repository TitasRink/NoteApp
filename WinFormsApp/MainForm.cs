using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    

    public partial class MainForm : Form
    {
        private string _username ;
        private string _password ;
        static string token = "";

        public string Username { get { return  UserInputBox.Text; } set { _username= value; } }
        public string Password { get { return PasswordInputBox.Text; } set { _password = value; } }

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
            var response = client.PostAsJsonAsync("/api/user/Log_in", user).Result;
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
            var response = client.PostAsJsonAsync("/api/user/Create_User", user).Result;
            var result = response.Content.ReadAsStringAsync();
            globalToken = result.Result.ToString();
            ShowLogedUserMenu();
            globalUserName = UserInputBox.Text;
            UsernameTextBox.Text = globalUserName;
        }

     
        private void AddNoteButton_Click(object sender, EventArgs e)
        {
            AddNote note = new AddNote();
            note.Show();
        }
        private void AddCategoryButton_Click(object sender, EventArgs e)
        {
            AddCastegory addCastegory = new AddCastegory();
            addCastegory.Show();
        }
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            UserInputBox.Text = "";
            PasswordInputBox.Text = "";
            globalToken = "";
            ShowLoginOnlyMenu();
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
            WelcomeLabel.Show();
            LogedInLabel.Show();
            
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
            LogedInLabel.Hide();

        }
        public static string globalToken = "";
        public static string globalUserName = "";
    }
}
