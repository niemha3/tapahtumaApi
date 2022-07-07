﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static TapahtumaApi.Program;
using System.Linq;
using System.Threading;

namespace TapahtumaApi
{
    public class Harri
    {
        //Haetaan kaikki paikat jotka ovat 24h auki
        public static async Task HaeAinaAukiOlevat()
        {
            const string url = "http://open-api.myhelsinki.fi/v1/places/";
            string urlParams = "";
            Console.Write("Haetaan, odota hetki");
            ShowDots();

            PlacesList paikkaLista = await ApiHelper.RunAsync<PlacesList>(url, urlParams);
            var aukioloAjat = from o in paikkaLista.data where o.opening_hours.hours != null select o;
            var ainaAuki = from o in aukioloAjat where o.opening_hours.hours[3].open24h == true select o;
                                 
            Console.WriteLine("Nämä paikat ovat auki 24h");
            foreach (var item in ainaAuki)
            {
                Console.WriteLine("\n" + item.name.fi);
                Console.WriteLine("\n" + item.description.body);
                Console.WriteLine("\n" + item.location.address.street_address);
                Console.WriteLine("\n***********************************************");
            }

        }

        // Haetaan kaikki shoppailupaikat
        public static async Task HaeOstospaikat()
        {
            const string url = "http://open-api.myhelsinki.fi/v1/";
            string urlParams = "places/?tags_search=SHOPPING";

            Console.Write("Haetaan, odota hetki");
            ShowDots();
            PlacesList ostosPaikat = await ApiHelper.RunAsync<PlacesList>(url, urlParams);
            
            foreach (var item in ostosPaikat.data)
            {
                Console.WriteLine(item.name.fi);
                Console.WriteLine("\n" + item.info_url);
                Console.WriteLine("\n" + item.location.address.street_address);
                Console.WriteLine("\n" + item.opening_hours.hours[0].opens +  " - " + item.opening_hours.hours[0].closes);
                Console.WriteLine("\n*********************************************************");
                
            }
        }
        public static async Task HaetaanTapahtumatTietyllaPvm() 
    {
            // Kuinka hakea tapahtumien nimet myös
            DateTime eventDate;
            while (true)
            {
                try
                {
                    Console.WriteLine("Anna päivämäärä tapahtumalle esim.(01/01/2000): ");
                    string inputDate = Console.ReadLine();
                    eventDate = DateTime.Parse(inputDate);
                }

                catch (FormatException)
                {
                    Console.WriteLine("Syötä päivämäärä oikeassa muodossa pp/kk/vvvv");
                    continue;
                }
                break;
            }
          
            const string url = "http://open-api.myhelsinki.fi/v1/events/";
            string urlParams = "";
           
            Console.Write("Haetaan, odota hetki");
            ShowDots();
            Eventlist tapahtumaList = await ApiHelper.RunAsync<Eventlist>(url, urlParams);

            var tapahtumatByDate = tapahtumaList.data.Where(date => date.event_dates.starting_day >= eventDate && date.event_dates.starting_day < eventDate.AddDays(1));

            while (true)
            {

                try
                {
                    foreach (var item in tapahtumatByDate)
                    {
                        Console.WriteLine(" " + item.name.fi);
                        Console.WriteLine("\n " + item.description.intro);
                        Console.WriteLine("\n " + item.event_dates.starting_day);
                        Console.WriteLine("\n " + item.location.address.street_address);


                        Console.WriteLine("*************************************************************************************************************************");
                    }

                }

            
                catch (NullReferenceException)
                {

                    Console.WriteLine("Haetulla päivämäärällä ei löytynyt tapahtumia.");
                    continue;
                }
                catch (Exception)
                {
                    Console.WriteLine("Jotain meni pieleen.");
                    continue;

                }
                break;
            }
          

        }

        static void ShowDots()
        {
            int i = 0;
            while (i < 3)
            {
                Console.Write(".");
                Thread.Sleep(500);
                i++;
            }
            Console.WriteLine("\n\n");
        }

    }

}
