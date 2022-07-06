using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static TapahtumaApi.Program;
using System.Linq;

namespace TapahtumaApi
{
    public class Harri
    {
    public static async Task HarrinMetodi() 
    {
            Console.WriteLine("Anna päivämäärä tapahtumalle esim.(01/01/2000): ");
            string inputDate = Console.ReadLine();
            DateTime eventDate = DateTime.Parse(inputDate);
           
          
            const string url = "http://open-api.myhelsinki.fi/v1/events/";
            string urlParams = "";

            Eventlist tapahtumaList = await ApiHelper.RunAsync<Eventlist>(url, urlParams);

            var tapahtumatByDate = tapahtumaList.data.Where(date => date.event_dates.starting_day >= eventDate && date.event_dates.starting_day < eventDate.AddDays(1));

            foreach (var item in tapahtumatByDate)
            {
                Console.WriteLine(" " + item.name.fi);
                Console.WriteLine("\n " + item.description.intro);
                Console.WriteLine("\n " + item.event_dates.starting_day);
                Console.WriteLine("\n " + item.location.address.street_address);


                Console.WriteLine("*************************************************************************************************************************");
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

    }

}
