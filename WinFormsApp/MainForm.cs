using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Formatting;
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
        //public static string categoryRename = "";
        //public static string noteSetectedFromList = "";

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
                        MessageBox.Show("No user found");
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
                return;
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
                    DataViewAsyncCategory();
                }
            }
        }

        private async void RemoveButton_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("https://localhost:44317/");
                    CategoryModelForm cate = new() { Name = CategoryListView.SelectedItems[0].Text };
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", globalToken);
                    string inputJsonNote = JsonConvert.SerializeObject(cate);
                    HttpContent inputContentNote = new StringContent(inputJsonNote, Encoding.UTF8, "application/json");
                    var responseNote = client.PostAsync("/api/Services/Remove_Category", inputContentNote).Result;

                    if (responseNote.IsSuccessStatusCode)
                    {
                        CategoryListView.Items.Clear();
                        await DataViewAsyncCategory();
                        MessageBox.Show("Category deleted");
                    }
                }
                catch (Exception t)
                {
                    MessageBox.Show(t.Message.ToString());
                }
            }
        }

        private async void RemoveNoteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NotelistView.SelectedItems[0].Text))
            {
                MessageBox.Show("Select message to remove");
            }
            else
            {
                using var client = new HttpClient();
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
                        NotelistView.Items.Clear();
                        DataViewNotes();
                        MessageBox.Show("Note deleted");
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
            using var client = new HttpClient();
            try
            {
                client.BaseAddress = new Uri("https://localhost:44317/");
                NoteModelForm note = new() { Name = NoteNameTextBox.Text, Message = NoteMessageTextBox.Text, IdName = globalUserName };
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", globalToken);
                string inputJson = JsonConvert.SerializeObject(note);
                HttpContent inputContent = new StringContent(inputJson, Encoding.UTF8, "application/json");
                var response = client.PostAsync("/api/Services/Create_note_and_mesage", inputContent).Result;
                DataViewNotes();
                NoteNameTextBox.Text = "";
                NoteMessageTextBox.Text = "";
            }
            catch (Exception t)
            {
                MessageBox.Show(t.Message.ToString());
            }
        }

        private void AddCategoryButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CategoryTextBoxAddRemove.Text))
            {
                MessageBox.Show("Fill up empty field");
            }
            else
            {
                CategoryListView.Items.Clear();
                using var client = new HttpClient();
                try
                {
                    client.BaseAddress = new Uri("https://localhost:44317/");
                    CategoryModelForm cat = new() { Name = CategoryTextBoxAddRemove.Text, UserNameId = globalUserName };
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", globalToken);
                    string inputJson = JsonConvert.SerializeObject(cat);
                    HttpContent inputContent = new StringContent(inputJson, Encoding.UTF8, "application/json");
                    var response = client.PostAsync("/api/Services/Create_Category", inputContent).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        DataViewAsyncCategory();
                    }
                }
                catch (Exception t)
                {
                    MessageBox.Show(t.Message.ToString());
                }
                CategoryTextBoxAddRemove.Text = "";
            }

            //if (string.IsNullOrEmpty(NotelistView.SelectedItems.ToString()))
            //{
            //    MessageBox.Show("Please select any note");
            //    return;
            //}
            //else
            //{
            //    AddCastegory addCastegory = new AddCastegory();
            //    addCastegory.Show();
            //}
        }

        private async void EditButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NoteMessageTextBox.Text))
            {
                MessageBox.Show("Fill up message");
            }
            else
            {
                using var client = new HttpClient();
                try
                {
                    client.BaseAddress = new Uri("https://localhost:44317/");
                    NoteModelForm note = new() { Name = NotelistView.SelectedItems[0].Text, Message = NoteMessageTextBox.Text };
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", MainForm.globalToken);
                    string inputJson = JsonConvert.SerializeObject(note);
                    var inputContent = new StringContent(inputJson, Encoding.UTF8, "application/json");
                    var response = client.PostAsync("/api/Services/Update_Note", inputContent).Result;
                    NotelistView.Items.Clear();
                    DataViewNotes();
                }
                catch (Exception t)
                {
                    MessageBox.Show(t.Message.ToString());
                }
            }

            //EditNote editNote = new EditNote();
            //noteSetectedFromList = NotelistView.SelectedItems[0].Text;
            //if (noteSetectedFromList == null)
            //{
            //    MessageBox.Show("Select Note to Edit");
            //    return;
            //}
            //else
            //{
            //    editNote.Show();
            //}

        }

        private async void RenameCategory_Click(object sender, EventArgs e)
        {
            if(CategoryListView.SelectedItems[0].Text == null || string.IsNullOrEmpty(CategoryTextBoxAddRemove.Text))
            {
                MessageBox.Show("Fill up empty field");
            }
            else
            {
                using var client = new HttpClient();
                try
                {
                    client.BaseAddress = new Uri("https://localhost:44317/");
                    CategoryModelForm cate = new() { Name = CategoryListView.SelectedItems[0].Text, UserNameId = CategoryTextBoxAddRemove.Text };
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", MainForm.globalToken);
                    string inputJson = JsonConvert.SerializeObject(cate);
                    var inputContent = new StringContent(inputJson, Encoding.UTF8, "application/json");
                    var response = client.PostAsync("/api/Services/Rename_category_name", inputContent).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        ClearViewList();
                        MessageBox.Show("Renamed");
                        DataViewNotes();
                        DataViewAsyncCategory();
                    }
                    else
                    {
                        MessageBox.Show(response.StatusCode.ToString());
                    }
                }
                catch (Exception t)
                {
                    MessageBox.Show(t.Message.ToString());
                }
            }
            //RenameCategory category = new RenameCategory();
            //categoryRename = categorieNameList.SelectedItem.ToString();
            //if (categoryRename == null)
            //{
            //    MessageBox.Show("Select Category to Rename");
            //    return ;
            //}
            //else
            //{
            //    category.Show();
            //}
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
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", globalToken);

            List<CategoryModelForm> categories = null;
            HttpContent inputContent = new StringContent("application/json", Encoding.UTF8);
            var resultCategory = client.GetAsync("/api/Services/Find_Categories").GetAwaiter().GetResult();
            var jsonStringcategory = await resultCategory.Content.ReadAsStringAsync();
            categories = JsonConvert.DeserializeObject<List<CategoryModelForm>>(jsonStringcategory);
         

            foreach (var item in categories)
            {
                CategoryListView.Items.Add(item.Name.ToString());
            }
        }

        public async Task DataViewNotes()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44317/");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", globalToken);

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
            using var client = new HttpClient();
            try
            {
                client.BaseAddress = new Uri("https://localhost:44317/");
                CategoryModelForm cate = new() { Name = NotelistView.SelectedItems[0].Text, UserNameId = CategoryListView.SelectedItems[0].Text };
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", globalToken);
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
            RemoveNoteButton.Show();
            NotelistView.Show();
            MoveToCategory.Show();
            WelcomeNoteApp.Hide();
            FillterByCategoryButton.Show();
            ShowAllButton.Show();
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
            RemoveNoteButton.Hide();
            NotelistView.Hide();
            MoveToCategory.Hide();
            WelcomeNoteApp.Show();
            FillterByCategoryButton.Hide();
            ShowAllButton.Hide();
        }

        public void ClearViewList()
        {
            NotelistView.Items.Clear();
            CategoryListView.Items.Clear();
        }

        private async void FillterByCategoryButton_Click(object sender, EventArgs e)
        {
            using var client = new HttpClient();
            try
            {
                client.BaseAddress = new Uri("https://localhost:44317/");
                CategoryModelForm cate = new() { Name = CategoryListView.SelectedItems[0].Text, UserNameId = globalUserName };
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", globalToken);
                string inputJsonNote = JsonConvert.SerializeObject(cate);
                HttpContent inputContentNote = new StringContent(inputJsonNote, Encoding.UTF8, "application/json");
                var responseNote = client.PostAsync("/api/Services/Find_Notes_by_Category", inputContentNote).Result;
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

        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            CategoryListView.Items.Clear();
            NotelistView.Items.Clear();
            DataViewNotes();
            DataViewAsyncCategory();
        }

        private async void AddImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files (*.jpg;*.jepg;.*.gif;) |*.jpg;*.jepg;.*.gif";

            MemoryStream ms = new MemoryStream();
            var fileName = openFile.FileName;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                //pictureBox.Load(openFile.FileName);
                fileName = openFile.FileName;
            }

            byte[] imgdata = File.ReadAllBytes(fileName);


            //var imageContent = new ByteArrayContent(imgdata);
            //imageContent.Headers.Add("Bearer", globalToken);
            //imageContent.Headers.ContentType = MediaTypeHeaderValue.Parse("image/jpeg");

            //using var client = new HttpClient();
            //client.BaseAddress = new Uri("https://localhost:44317/");
            //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", globalToken);


            //try
            //{

            //    HttpResponseMessage response = await client.PostAsJsonAsync("/api/Services/AddImg", imageContent);

            //    string responseContent = await response.Content.ReadAsStringAsync();

            //}
            //catch (Exception ex)
            //{
            //    throw;
            //}



            using var client = new HttpClient();
            //client.BaseAddress = new Uri("https://localhost:44317/");
            //NoteModelForm imageData = new() { ImgData = imgdata, Name = NotelistView.SelectedItems[0].Text };
            //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", globalToken);

            //var response = client.PostAsJsonAsync("/api/Services/AddImg", imageData).Result;

            client.BaseAddress = new Uri("https://localhost:44317/");
            NoteModelForm imageModel = new() { Name = NotelistView.SelectedItems[0].Text, ImgData = imgdata };
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", globalToken);
            string inputJson = JsonConvert.SerializeObject(imageModel);
            HttpContent inputContent = new StringContent(inputJson, Encoding.UTF8, "application/json");
            var response = client.PostAsync("/api/Services/AddImg", inputContent).Result;
            
            
            Console.WriteLine("daasdas");
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //if (response.IsSuccessStatusCode)
            //{
            //    MessageBox.Show("Image Added to Note");
            //}
            //else
            //{
            //    MessageBox.Show("error");
            //}
        }
    }
}
