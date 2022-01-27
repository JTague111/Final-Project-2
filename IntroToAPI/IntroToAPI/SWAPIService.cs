﻿using IntroToAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace IntroToAPI
{
    class SWAPIService
    {
        private readonly HttpClient _httpClient = new HttpClient();

        // Async Method
        public async Task<Person> GetPersonAsync(string url)
        {
            // Get Request
            //HttpResponseMessage response = await _httpClient.GetAsync(url);

            //if (response.IsSuccessStatusCode)
            //{
            // Was a success
            //    Person person = await response.Content.ReadAsAsync<Person>();
            //    return person;
            //}
            //
            // Was not a success
            //return null;

            return await GetAsync <Person>(url);
        }

        // Async Method
        public async Task<Vehicle> GetVehicleAsync(string url)
        {
            // Get Request
            HttpResponseMessage response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                // Was a success
                Vehicle vehicle = await response.Content.ReadAsAsync<Vehicle>();
                return vehicle;
            }

            // Was not a success
            return null;
        }

        public async Task<T> GetAsync<T>(string url) //Where T: class
        {
            HttpResponseMessage response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                T content = await response.Content.ReadAsAsync<T>();
                return content;
            }

            return default;
            // Return null;
        }

        public async Task<SearchResult<Person>> GetPersonSearchAsync(string query)
        {
            HttpResponseMessage response = await _httpClient.GetAsync("https://swapi.dev/api/people?search" + query);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<SearchResult<Person>>();
            }

            return null;
        }

        public async Task<SearchResult<T>> GetSearchAsync<T>(string query, string category)
        {
            HttpResponseMessage response = await _httpClient.GetAsync("https://swapi.dev/api/people?search" + query);

            return response.IsSuccessStatusCode
                ? await response.Content.ReadAsAsync<SearchResult<T>>()
                : default;
        }

        public async Task<SearchResult<Vehicle>> GetVehicleSearchAsync(string query)
        {
            return await GetSearchAsync<Vehicle>(query, "vehicles");
        }
    }
}
