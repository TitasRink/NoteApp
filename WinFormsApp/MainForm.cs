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



        public string Username { get { return _username = UserInputBox.Text; } set { _username= value; } }
        public string Password { get { return PasswordInputBox.Text; } set { _password = value; } }

        public MainForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click_1(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44317/");
                LoginClass lgn = new LoginClass { UserName = UserInputBox.Text, Password = PasswordInputBox.Text };
                var response = client.PostAsJsonAsync("/api/user/Log in", lgn).Result;
                var a = response.Content.ReadAsStringAsync();

            }
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    APIHelper api = new APIHelper();
        //    api.Crateuser(Username, Password);
        //    MessageBox.Show("loged in");
        //}
        private void button1_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44317/");
                LoginClass lgn = new LoginClass { UserName = UserInputBox.Text, Password = PasswordInputBox.Text };
                var response = client.PostAsJsonAsync("/api/user/Create User", lgn).Result;
                var a = response.Content.ReadAsStringAsync();

            }
        }

        private class LoginClass
        {
            public string UserName { get; set; }
            public string Password { get; set; }
        }
    }
}
