using System;
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
            Console.WriteLine("Valitse seuraavista vaihtoehdoista\n" +
               "1. \n" +
               "2.\n" +
               "3.\n" +
               "4. Jere metodi\n" +
               "5. Poistua sovelluksesta \n");
            int valikko = Convert.ToInt32(Console.ReadLine());
            switch (valikko)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    Console.Clear();
                    await Jere.JerenMetodi();
                    Console.ReadLine();
                    break;
                case 5:
                    Console.Clear();
                    Jere.MenoMetodi();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("\nValitse oikea numero\n");
                    break;
            }
           // await GetTapahtumaInfo();
        
            //await Harri.HarrinMetodi();
            //Console.ReadLine();
            //await Jere.JerenMetodi();

        }



        public static async Task GetTapahtumaInfo()
        {
            
            const string url = "http://open-api.myhelsinki.fi/v1/place/1";
            string urlParams = "";


           
               
            }
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

