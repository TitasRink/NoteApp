using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;


namespace WinFormsNoteApp.APIHelpers
{
    public class APIHelper
    {
        public HttpClient apiClient;

        public APIHelper()
        {
            InitializeClient();
        }

        private void InitializeClient()
        {
            apiClient = new HttpClient();
            apiClient.BaseAddress = new Uri("https://localhost:44317/");
            apiClient.DefaultRequestHeaders.Accept.Clear();
            apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<string> Authenticate(string username, string password)
        {
            var data = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string,string>("grand_type", "password"),
                new KeyValuePair<string,string>("username", username),
                new KeyValuePair<string,string>("grand_type", password)
            });

            using (HttpResponseMessage response = await apiClient.PostAsync("/api/user/Log in", data))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    return result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }

            }
        }
    }
}
