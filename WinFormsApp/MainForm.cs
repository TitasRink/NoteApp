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
        static string ReturnToken(string token)
        {
            var _token = token;
            return token;
        }
        private void LoginButton_Click_1(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44317/");
                UserModel user = new UserModel { UserName = UserInputBox.Text, Password = PasswordInputBox.Text };
                var response = client.PostAsJsonAsync("/api/user/Log in", user).Result;
                Task<string> result = response.Content.ReadAsStringAsync();
                globalToken = result.Result.ToString();

                ShowLogedUserMenu();
            }
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    using (var client = new HttpClient())
        //    {
        //        client.BaseAddress = new Uri("https://localhost:44317/");
        //        UserModel user = new UserModel { UserName = UserInputBox.Text, Password = PasswordInputBox.Text };
        //        var response = client.PostAsJsonAsync("/api/user/Create User", user).Result;
        //        token = response.Content.ReadAsStringAsync().ToString();
        //        ShowLogedUserMenu();
        //    }
        //}

        private void AddCategoryButton_Click(object sender, EventArgs e)
        {
            AddCastegory addCastegory = new AddCastegory();
            addCastegory.Show();
            //using (var client = new HttpClient())
            //{
            //    client.BaseAddress = new Uri("https://localhost:44317/");
            //    client.DefaultRequestHeaders.Add("Authorization", token);
            //    CategoryModel cat = new CategoryModel { Name = }
            //   // client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            //    var response = client.PostAsJsonAsync("/api/Services/Create Category", ).Result;
            //    MessageBox.Show(response.ToString());
            //}
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
        public static string globalToken;
    }
}
