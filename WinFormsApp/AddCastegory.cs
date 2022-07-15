using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class AddCastegory : Form
    {
        public AddCastegory()
        {
            InitializeComponent();
        }

        private void CastegoryConfirmButton_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("https://localhost:44317/");
                    CategoryModelForm cat = new CategoryModelForm { Name = CategoryTextBox.Text, IdName = MainForm.globalUserName };
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", MainForm.globalToken);
                    var inputJson = JsonConvert.SerializeObject(cat);
                    HttpContent inputContent = new StringContent(inputJson, Encoding.UTF8, "application/json");
                    var response = client.PostAsync("/api/Services/Create_Category", inputContent).Result;
                    MessageBox.Show("dasd");
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
