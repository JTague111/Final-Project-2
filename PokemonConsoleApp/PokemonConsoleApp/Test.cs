using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PokemonConsoleApp
{
    class Test
    {
        private static string APIUrl = "http://localhost:7005/orderapi/";
        public static async Task GetDataWithAuthentication()
        {
            var authCredential = Encoding.UTF8.GetBytes("{userTest}:{passTest}");
            using (var client = new HttpClient())
            {


                client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Basic", Convert.ToBase64String(authCredential));
                client.BaseAddress = new Uri(APIUrl);
                HttpResponseMessage response = await client.GetAsync(APIUrl + "GetOrders");

                if (response.IsSuccessStatusCode)
                {
                    var readTask = response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    var rawResponse = readTask.GetAwaiter().GetResult();
                    Console.WriteLine(rawResponse);
                }
                Console.WriteLine("Complete");
            }
        }
    }
}
