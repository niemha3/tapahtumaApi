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
        //Console.WriteLine("Anna päivämäärä tapahtumalle id: ");
        //string inputId = Console.ReadLine();

        const string url = "http://open-api.myhelsinki.fi/v1/events/";
        string urlParams = "";

        Eventlist tapahtumaList = await ApiHelper.RunAsync<Eventlist>(url, urlParams);

            foreach (Datum d in tapahtumaList.data)
            {
                Console.WriteLine(d.name.fi + " " + d.event_dates.starting_day);
            }
           
            //Console.WriteLine(tapahtuma2.name.fi.ToString());
            //Console.WriteLine(tapahtuma2.info_url.ToString());
            //Console.WriteLine(tapahtuma2.modified_at.Ticks.ToString());
            //Console.WriteLine(tapahtuma2.opening_hours.hours[1].weekday_id.ToString());




        }

    }

}
