using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class AddNote : Form
    {
        public AddNote()
        {
            InitializeComponent();
        }

        private void NoteConfirmButton_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("https://localhost:44317/");
                    NoteModelForm note = new() { Name = NoteNameTextBox.Text, Message = NoteTextBox.Text, IdName = MainForm.globalUserName };
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", MainForm.globalToken);
                    string inputJson = JsonConvert.SerializeObject(note);
                    HttpContent inputContent = new StringContent(inputJson, Encoding.UTF8, "application/json");
                    var response = client.PostAsync("/api/Services/Create_note_and_mesage", inputContent).Result;
                }
                catch (Exception t)
                {
                    MessageBox.Show(t.Message.ToString());
                }
            }
            Close();
        }
    }
}
