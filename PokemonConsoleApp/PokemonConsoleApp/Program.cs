using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PokemonConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient()
            {

            }
            var authCredential = Encoding.UTF8.GetBytes("eqv3jJIs0YVatZ3JDsYxFcoHcD1k4GMenBCI_NvmvUu95OD9XbxzlkPbpTgepLMbr3ZcLAfwiWvvlmXpCW-iG8iBJULXZCBF_QJgoDtgTlk9nebAhFKDQFXZJr8CAWDXgaJ779AtkEwY6TatmiSnaVq89fEBzS-CVeewnXAq_fJyzNLvGthIEzW8INQoyh3RpOI0dL5UCn3EASZM0Cvs33R8TyQuynqQ150QWNsp7Q8hzmU3nsmbL68GWRb2leqcYpZVE_2Wm3l1sOgFP4vML6rKS-iTxdKgJ5nXjq6iaOa5P4qd5qg2Uft9jmMoD15xMnZN8Sf_MOoTpo-lKyftfuqaiy135Hhtu5VZgzlB7QJ_rSnooA2C58lakcHfRl8Lkn9DDacW9S0-v5t16G-uHngvdhX0_9pcE-8L6qQV_shno54057brZcVl88qisBcRt5rvKIV7gsDK9VCfypU7rkGzaj719FRUrkNqFk6bP0LRdEm_aUs-BSBU-hxNSrhY");
            client.DefaultRequestHeaders.Authorization =
    new AuthenticationHeaderValue("Basic", Convert.ToBase64String(authCredential));
            HttpResponseMessage response = client.GetAsync("https://localhost:44324/api/PokemonSet").Result;   

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);
            }
            Console.ReadLine();

        }
    }
}

