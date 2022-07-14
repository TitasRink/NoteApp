using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
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
                CategoryModel cat = new CategoryModel { Name = CategoryTextBox.Text };

                client.BaseAddress = new Uri("https://localhost:44317/");
                //client.DefaultRequestHeaders.Add("Bearer", MainForm.globalToken);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", MainForm.globalToken);
                var response = client.PostAsJsonAsync("/api/Services/Create Category", cat).Result;
                MessageBox.Show(response.ToString());
            }
        }
    }
}
