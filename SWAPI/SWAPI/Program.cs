using System;
using System.Net.Http;
namespace SWAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient _client = new HttpClient();

            // we want to make a get request just like in postman!
            HttpResponseMessage response = _client.GetAsync("https://swapi.dev/api/people/1").Result;

            if (response.IsSuccessStatusCode)
        }
    }
}
