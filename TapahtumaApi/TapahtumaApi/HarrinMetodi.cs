using System;
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
    public static async Task HarrinMetodi() 
    {
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
            //foreach (Datum d in tapahtumaList.data)
            //{
            //    Console.WriteLine(d.name.fi + " " + d.event_dates.starting_day);
            //}

            //Console.WriteLine(tapahtuma2.name.fi.ToString());
            //Console.WriteLine(tapahtuma2.info_url.ToString());
            //Console.WriteLine(tapahtuma2.modified_at.Ticks.ToString());
            //Console.WriteLine(tapahtuma2.opening_hours.hours[1].weekday_id.ToString());

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
