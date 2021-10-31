using System.Collections.Generic;
using System;
using Model;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;

namespace assignment.Data
{
    public class InMemoryUserService :IUserService
    {
        private static readonly HttpClientHandler handler = new HttpClientHandler(){
            ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
        };

        private static readonly HttpClient client = new HttpClient(handler);

        private static readonly string webApiUrl = "https://localhost:5003/User";

        public async Task<User> ValidateUser(string userName, string password){
            HttpResponseMessage response = await client.GetAsync(webApiUrl+"?username="+userName+"&password="+password);
            if (response.IsSuccessStatusCode){
                string jsonUser = await response.Content.ReadAsStringAsync();
                Console.WriteLine(jsonUser);   
                User usr = JsonSerializer.Deserialize<User>(jsonUser);
                Console.WriteLine(usr.BirthYear);
                return usr;
            }
            throw new System.Exception("User not found or incorrect password.");
        }
    }
}