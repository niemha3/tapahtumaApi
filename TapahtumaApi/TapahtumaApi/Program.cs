using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;


namespace TapahtumaApi
{
    class Program
    {
        static async Task Main(string[] args)
        {

                Console.ForegroundColor = ConsoleColor.Blue;
            string textToEnter = @"
  _    _ ______ _       _____ _____ _   _ _  _______ _____ _____ _________     __
 | |  | |  ____| |     / ____|_   _| \ | | |/ /_   _/ ____|_   _|__   __\ \   / /
 | |__| | |__  | |    | (___   | | |  \| | ' /  | || |      | |    | |   \ \_/ / 
 |  __  |  __| | |     \___ \  | | | . ` |  <   | || |      | |    | |    \   /  
 | |  | | |____| |____ ____) |_| |_| |\  | . \ _| || |____ _| |_   | |     | |   
 |_|  |_|______|______|_____/|_____|_| \_|_|\_\_____\_____|_____|  |_|     |_|   ";
            Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nby Milan Jaff ");

            
            
            
 
       int valikko;
            do
            {
                
                Console.WriteLine("\n\n\t\t\tValitse seuraavista vaihtoehdoista\n\n" +
               "\t1. Hae tapahtumia päivämäärän mukaan\n" +
               "\t2. Hae paikat, jotka ovat auki 24h\n" +
               "\t3. Hae shoppailupaikat\n" +
               "\t4. Paikallisia hesan urheilumahdollisuuksia\n" +
               "\t5. Kaikki ruotsinkieliset tapahtumat kesällä 2022\n" +
               "\t6. Tapahtumat Helsingissä huomenna\n" +
               "\t7. Poistu sovelluksesta\n");
                valikko = Convert.ToInt32(Console.ReadLine());
                switch (valikko)
                {
                    case 1:
                        await Harri.HaetaanTapahtumatTietyllaPvm();
                        Console.ReadKey();
                        break;
                    case 2:
                        await Harri.HaeAinaAukiOlevat();
                        Console.ReadKey();
                      
                        break;
                    case 3:
                        await Harri.HaeOstospaikat();
                        Console.ReadKey();
                        break;
                    case 4: Console.Clear();
                        await Jere.JerenMetodi();
                      
                        break;
                    case 7:
                        Console.Clear();
                        Jere.MenoMetodi();
                        break;
                    case 6: await Laura.LauranMetodi();
                        Console.ReadKey();
                        break;

                    case 5: await Eventit.LauranMetodi2();
                        Console.ReadKey();
                        break;
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        
                        Console.WriteLine("\n\n\n\n\n\t\t|||||||||||||||||||||||");
                        Console.WriteLine("\t\t|         !           |");
                        Console.WriteLine("\t\t|    VÄÄRÄ VALINTA    |");
                        Console.WriteLine("\t\t|         !           |");
                        Console.WriteLine("\t\t|||||||||||||||||||||||\n\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    
                }
                
            }
            while (valikko != 7);
            

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

