using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
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
            try
            {
                using var client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:44317/");
                UserModelForm user = new() { UserName = UserInputBox.Text, Password = PasswordInputBox.Text };
                var response = client.PostAsJsonAsync("/api/user/Log_in", user).Result;
                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("User name or password is incorrect");
                    UserInputBox.Text = "";
                    PasswordInputBox.Text = "";
                }
                else
                {
                    var result = response.Content.ReadAsStringAsync();
                    globalToken = result.Result.ToString();
                    globalUserName = UserInputBox.Text;
                    UsernameTextBox.Text = globalUserName;
                    ShowLogedUserMenu();
                    dataViewAsync();
                }
            }
            catch (Exception t)
            {
                MessageBox.Show(t.Message);
            }
        }
        private void AddUserButton_Click(object sender, EventArgs e)
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44317/");
            UserModelForm user = new() { UserName = UserInputBox.Text, Password = PasswordInputBox.Text };
            var response = client.PostAsJsonAsync("/api/user/Create_User", user).Result;
            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show("User name or password allready exists");
                UserInputBox.Text = "";
                PasswordInputBox.Text = "";
                ShowLoginOnlyMenu();
            }
            else
            {
                var result = response.Content.ReadAsStringAsync();
                globalToken = result.Result.ToString();
                ShowLogedUserMenu();
                globalUserName = UserInputBox.Text;
                UsernameTextBox.Text = globalUserName;
            }
        }
        /// <summary>
        /// hardcode parameter need  locate selected from list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("https://localhost:44317/");
                    NoteModelForm note = new() { Name = "bbbb" };
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", MainForm.globalToken);
                    string inputJson = JsonConvert.SerializeObject(note);
                    HttpContent inputContent = new StringContent(inputJson, Encoding.UTF8, "application/json");
                    var response = client.PostAsync("/api/Services/Remove_Note", inputContent).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Note deleted");
                    }
                    else
                    {
                        MessageBox.Show("error");
                    }

                }
                catch (Exception t)
                {
                    MessageBox.Show(t.Message.ToString());
                }
            }
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
        private void EditButton_Click(object sender, EventArgs e)
        {
            EditNote editNote = new EditNote();
            editNote.Show();
        }
        private void RenameCategory_Click(object sender, EventArgs e)
        {
            RenameCategory category = new RenameCategory();
            category.Show();
        }
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            UserInputBox.Text = "";
            PasswordInputBox.Text = "";
            globalToken = "";
            globalUserName = "";
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
            WelcomeLabel.Show();
            LogedInLabel.Show();
            RemoveButton.Show();
            RenameCategoryButton.Show();
            
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
            LogedInLabel.Hide();
            RemoveButton.Hide();
            RenameCategoryButton.Hide();
        }

        private void dataViewAsync()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44317/");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", MainForm.globalToken);
                HttpContent inputContent = new StringContent("application/json", Encoding.UTF8);
                var httpResponseMessage = client.GetAsync("/api/Services/Find_all_Notes_by_name").GetAwaiter().GetResult();
                
                dataGridView1 = new DataGridView();
                dataGridView1.colu

                
            }
            
        }
        public static string globalToken = "";
        public static string globalUserName = "";
    }
}
