using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ChatWinForm.Chat
{
    public class UserService : IUserService
    {
        private static string _location = "Users";
        private readonly HttpClient _httpClient;

        public UserService(IHttpClientFactory factory)
        {
            _httpClient = factory.CreateClient("Base");
        }

        public void SetAuthorization(string jwt)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwt);
        }

        public async Task<List<string>> GetUsers()
        {
            using (var response = await _httpClient.GetAsync($"{_location}"))
            {
                var users = new List<string>();
                if (response.IsSuccessStatusCode)
                {
                    users = JsonSerializer.Deserialize<List<string>>(await response.Content.ReadAsStringAsync());
                }
                return users;
            }
        }
    }

    public interface IUserService
    {
        void SetAuthorization(string jwt);
        Task<List<String>> GetUsers();
    }
}
