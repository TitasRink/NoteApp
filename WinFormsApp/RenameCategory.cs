using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class RenameCategory : Form
    {
        public RenameCategory()
        {
            InitializeComponent();
        }
    
        private void RenameCastegoryConfirmButton_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("https://localhost:44317/");
                    CategoryModelForm cate = new() { Name = MainForm.categoryRename , UserNameId = RenameCategoryTextBox.Text };
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", MainForm.globalToken);
                    string inputJson = JsonConvert.SerializeObject(cate);
                    var inputContent = new StringContent(inputJson, Encoding.UTF8, "application/json");
                    var response = client.PostAsync("/api/Services/Rename_category_name", inputContent).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Renamed");
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
            Close();
        }
    }
}
