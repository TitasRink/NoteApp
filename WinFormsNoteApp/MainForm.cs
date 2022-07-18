using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsNoteApp.APIHelpers;

namespace WinFormsNoteApp
{
    public partial class MainForm : Form
    { 
        private string _username;
        private string _password;

        

        public string Username { get { return _username; } set { _username = UserInputBox.Text; } }
        public string Password { get { return _password; } set { _password = PasswordInputBox.Text; } }

        public MainForm()
        {
            InitializeComponent();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async Task<string> LoginButton_Click(object sender, EventArgs e)
        {
            APIHelper api = new APIHelper();
            var result = await api.Authenticate(Username, Password);
            return result;
        }
    }
}
