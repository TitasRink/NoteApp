using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class EditNote : Form
    {
        public EditNote()
        {
            InitializeComponent();
        }
        
        private void EditNoteConfirmButton_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                MainForm form = new();
                try
                {
                    client.BaseAddress = new Uri("https://localhost:44317/");
                    NoteModelForm note = new() { Name = MainForm.noteSetectedFromList , Message = EditNoteTextBox.Text };
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", MainForm.globalToken);
                    string inputJson = JsonConvert.SerializeObject(note);
                    var inputContent = new StringContent(inputJson, Encoding.UTF8, "application/json");
                    var response = client.PostAsync("/api/Services/Update_Note", inputContent).Result;
                   
                    
                    form.DataViewNotes();
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
