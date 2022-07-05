﻿using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace TapahtumaApi
{
    class Program
    {
        static async Task Main(string[] args)
        {
           await GetTapahtumaInfo();
            Console.ReadLine();
        }



        public static async Task GetTapahtumaInfo()
        {
            
            const string url = "http://open-api.myhelsinki.fi/v1/place/1";
            string urlParams = "";
      
            Contact tapahtuma = await ApiHelper.RunAsync<Contact>(url, urlParams);

            Console.WriteLine(tapahtuma.name.fi.ToString());
            Console.WriteLine(tapahtuma.info_url.ToString());
            Console.WriteLine(tapahtuma.modified_at.Ticks.ToString());
            Console.WriteLine(tapahtuma.opening_hours.hours[1].weekday_id.ToString());
          

        }

        public static class ApiHelper
        {
           
            // create HTTP client
            private static HttpClient GetHttpClient(string url)
            {
                var client = new HttpClient { BaseAddress = new Uri(url) };
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                return client;
            }

            public static async Task<T> RunAsync<T>(string url, string urlParams)
            {
                try
                {
                    using (var client = GetHttpClient(url))
                    {
                        // send GET request
                        HttpResponseMessage response = await client.GetAsync(urlParams);

                        if (response.StatusCode == HttpStatusCode.OK)
                        {
                            var json = await response.Content.ReadAsStringAsync();

                            // JSON to an object
                            var result = JsonSerializer.Deserialize<T>(json);
                            return result;
                        }

                        return default(T);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    return default(T);
                }



            }

        }
    }
}
