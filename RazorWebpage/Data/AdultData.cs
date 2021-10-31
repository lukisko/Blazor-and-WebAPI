using Model;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using System;
using System.Text;

namespace assignment.Data
{
    public class AdultData : IAdultData
    {
        private static readonly HttpClientHandler handler = new HttpClientHandler(){
            ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
        };

        private static readonly HttpClient client = new HttpClient(handler);

        private static readonly string webApiUrl = "https://localhost:5003/Adults/";
        public AdultData(){
            //file = new FileContext();
        }
        public async Task<IList<Adult>> GetAdults(){
            //List<Adult> tmp = new List<Adult>(file.Adults);
            HttpResponseMessage response = await client.GetAsync(webApiUrl);
            string body = await response.Content.ReadAsStringAsync();
            IList<Adult> result = JsonSerializer.Deserialize<IList<Adult>>(body);
            //Console.WriteLine("capacity of adult list: "+result.Count);
            //Console.WriteLine("First adult: "+result.ElementAt(1).Id);
            //Console.WriteLine("First adult: "+result.ElementAt(1).FirstName);
            return result;
        }
        public async Task AddAdult(Adult adult){
            HttpResponseMessage response = await client.PostAsync(webApiUrl,makeStringContent(adult));
            Console.WriteLine(response.StatusCode);
            if (!response.IsSuccessStatusCode){
                Console.WriteLine(await response.Content.ReadAsStringAsync());
                throw new Exception("unable to add adult"); 
            }
        }
        public async Task UpdateAdult(Adult adult){
            HttpResponseMessage message = await client.PutAsync(webApiUrl+adult.Id, makeStringContent(adult));
            if (!message.IsSuccessStatusCode){
                Console.WriteLine("help, there is something wrong with update adult, adult data class.");
                Console.WriteLine("content" + await message.Content.ReadAsStringAsync());
                Console.WriteLine("code: " + message.StatusCode);
            }
        }
        public async Task RemoveAdult(int personId){
            HttpResponseMessage response = await client.DeleteAsync(webApiUrl+""+personId);
            if (!response.IsSuccessStatusCode){
                throw new Exception("unable to delete the person");
            }
        }

        private StringContent makeStringContent<T>(T obj){
            string content = new string(JsonSerializer.Serialize(obj));
            StringContent request = new StringContent(
                content,
                Encoding.UTF8,
                "application/json"
            );
            return request;
        }
    }
}