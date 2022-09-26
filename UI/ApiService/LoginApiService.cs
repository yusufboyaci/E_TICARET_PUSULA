using System.Text;
using UI.Models;
using Newtonsoft.Json;

namespace UI.ApiService
{
    public class LoginApiService
    {
        private readonly HttpClient _httpClient;
        public LoginApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<bool> GetUser(string userName, string password)
        {
            LoginVM nesne = new LoginVM();
            nesne.UserName = userName;
            nesne.Password = password;
            string myContent = JsonConvert.SerializeObject(nesne);
            HttpContent httpContent = new StringContent(myContent, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _httpClient.PostAsync($"User/Login", httpContent);
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<bool>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                return false;
            }
        }
    }
}
