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
        public static string globalToken = "";
        public static string globalUserName = "";
        public static string categoryRename = "";
        public static string noteSetectedFromList = "";

        public MainForm()
        {
            InitializeComponent();
            ShowLoginOnlyMenu();
        }

        private void LoginButton_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(UserInputBox.Text) || string.IsNullOrEmpty(PasswordInputBox.Text))
            {
                MessageBox.Show("Please fill up fields");
                return;
            }
            else
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
                        DataViewNotes();
                        DataViewAsyncCategory();
                    }
                }
                catch (Exception t)
                {
                    MessageBox.Show(t.Message);
                }
            }
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UserInputBox.Text) || string.IsNullOrEmpty(PasswordInputBox.Text))
            {
                MessageBox.Show("Please fill up fields");
                return ;
            }
            else
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
        }
  
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("https://localhost:44317/");
                    CategoryModelForm cate = new() { Name = categorieNameList.SelectedItem.ToString() };
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", MainForm.globalToken);
                    string inputJsonNote = JsonConvert.SerializeObject(cate);
                    HttpContent inputContentNote = new StringContent(inputJsonNote, Encoding.UTF8, "application/json");
                    var responseNote = client.PostAsync("/api/Services/Remove_Category", inputContentNote).Result;
                    if (responseNote.IsSuccessStatusCode)
                    {
                        DataViewAsyncCategory();
                        MessageBox.Show("Category deleted");
                    }
                }
                catch (Exception t)
                {
                    MessageBox.Show(t.Message.ToString());
                }
            }
        }

        private void RemoveNoteButton_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("https://localhost:44317/");
                    NoteModelForm notes = new() { Name = NotelistView.SelectedItems[0].Text, IdName = globalUserName };
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", globalToken);
                    string inputJsonNote = JsonConvert.SerializeObject(notes);
                    HttpContent inputContentNote = new StringContent(inputJsonNote, Encoding.UTF8, "application/json");
                    var responseNote = client.PostAsync("/api/Services/Remove_Note", inputContentNote).Result;
                    if (responseNote.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Note deleted");
                        DataViewNotes();
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
            if(string.IsNullOrEmpty(NotelistView.SelectedItems.ToString()))
            {
                MessageBox.Show("Please select any note");
                return;
            }
            else
            {
                AddCastegory addCastegory = new AddCastegory();
                addCastegory.Show();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EditNote editNote = new EditNote();
            noteSetectedFromList = NotelistView.SelectedItems[0].Text;
            editNote.Show();
        }

        private void RenameCategory_Click(object sender, EventArgs e)
        {
            RenameCategory category = new RenameCategory();
            categoryRename = categorieNameList.SelectedItem.ToString();
            category.Show();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            UserInputBox.Text = "";
            PasswordInputBox.Text = "";
            globalToken = "";
            globalUserName = "";
            ShowLoginOnlyMenu();
            ClearViewList();
        }

        public async Task DataViewAsyncCategory()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44317/");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", MainForm.globalToken);

            List<CategoryModelForm> categories = null;
            HttpContent inputContent = new StringContent("application/json", Encoding.UTF8);
            var resultCategory = client.GetAsync("/api/Services/Find_Categories").GetAwaiter().GetResult();
            var jsonStringcategory = await resultCategory.Content.ReadAsStringAsync();
            categories = JsonConvert.DeserializeObject<List<CategoryModelForm>>(jsonStringcategory);

            foreach (var item in categories)
            {
                categorieNameList.Items.Add(item.Name.ToString());
            }
        }
        public async Task DataViewNotes()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44317/");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", MainForm.globalToken);

            List<NoteModelForm> notes = null;
            NoteModelForm notesID = new() { IdName = globalUserName };
            string inputJsonNote = JsonConvert.SerializeObject(notesID);
            var inputContentNote = new StringContent(inputJsonNote, Encoding.UTF8, "application/json");
            var responseNote = client.PostAsync("/api/Services/Find_all_Notes_by_name", inputContentNote).Result;
            var jsonStringNote = await responseNote.Content.ReadAsStringAsync();
            notes = JsonConvert.DeserializeObject<List<NoteModelForm>>(jsonStringNote);

            foreach (var item in notes)
            {
                ListViewItem list = new ListViewItem(item.Name.ToString());
                list.SubItems.Add(item.Message.ToString());
                NotelistView.Items.Add(list);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MoveToCategory_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("https://localhost:44317/");
                    CategoryModelForm cate = new() { Name = NotelistView.SelectedItems[0].Text, UserNameId = categorieNameList.SelectedItem.ToString()};
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", MainForm.globalToken);
                    string inputJsonNote = JsonConvert.SerializeObject(cate);
                    HttpContent inputContentNote = new StringContent(inputJsonNote, Encoding.UTF8, "application/json");
                    var responseNote = client.PostAsync("/api/Services/Move_note_to_category", inputContentNote).Result;
                    if (responseNote.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Note Moved");
                    }
                }
                catch (Exception t)
                {
                    MessageBox.Show(t.Message.ToString());
                }
            }
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
            categorieNameList.Show();
            RemoveNoteButton.Show();
            NotelistView.Show();
            MoveToCategory.Show();
            WelcomeNoteApp.Hide();
            FillterByCategoryButton.Show();

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
            categorieNameList.Hide();
            RemoveNoteButton.Hide();
            NotelistView.Hide();
            MoveToCategory.Hide();
            WelcomeNoteApp.Show();
            FillterByCategoryButton.Hide();
        }
        public void ClearViewList()
        {
            NotelistView.Items.Clear();
            categorieNameList.Items.Clear();
        }

        private async Task Fillter()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("https://localhost:44317/");
                    CategoryModelForm cate = new() { Name = categorieNameList.SelectedItem.ToString() };
                    string inputJsonNote = JsonConvert.SerializeObject(cate);
                    var inputContentNote = new StringContent(inputJsonNote, Encoding.UTF8, "application/json");
                    var responseNote = client.PostAsync("/api/Services/Find_all_Notes_by_Category", inputContentNote).Result;
                    var jsonStringNote = await responseNote.Content.ReadAsStringAsync();
                    var notes = JsonConvert.DeserializeObject<List<NoteModelForm>>(jsonStringNote);

                    NotelistView.Items.Clear();
                    foreach (var item in notes)
                    {
                        ListViewItem list = new ListViewItem(item.Name.ToString());
                        list.SubItems.Add(item.Message.ToString());
                        NotelistView.Items.Add(list);
                    }
                }
                catch (Exception t)
                {
                    MessageBox.Show(t.Message.ToString());
                }
            }

        }

        private void FillterByCategoryButton_Click(object sender, EventArgs e)
        {
            Fillter();
        }
    }
}
