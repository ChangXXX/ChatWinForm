using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace ChatWinForm.Walkthrough
{
    public class SignService : ISignService
    {
        private static string _location = "Users/";
        private readonly HttpClient _httpClient;

        public SignService(IHttpClientFactory factory)
        {
            _httpClient = factory.CreateClient("Base");
        }

        public async Task<User> Login(string name, string password)
        {
            using (var response = await _httpClient.GetAsync($"{_location}{name}/{password}"))
            {
                User user = null;
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    string jwt = response.Headers.GetValues("Jwt").FirstOrDefault();
                    user = new User(name, password);
                    user.Jwt = jwt;
                    return user;
                }
                else
                {
                    return user;
                }
            }
        }

        public async Task<bool> Signup(string name, string pwd)
        {
            var response = await _httpClient.PostAsJsonAsync(_location, new User(name, pwd));
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            
            return false;
        }
    }

    public interface ISignService
    {
        Task<User> Login(string name, string password);

        Task<bool> Signup(string name, string pwd);
    }
}
