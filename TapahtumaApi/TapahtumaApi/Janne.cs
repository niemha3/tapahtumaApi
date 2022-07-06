using System;
using System.Collections.Generic;
using System.Text;

namespace TapahtumaApi
{
    class Janne
    {

        public static Task MethodJanne()
        {
            
            Console.WriteLine("Lisää vuodenaika:")
            string timeOfYear = Console.ReadLine();
                                                                                                // ulkoilma-aktiviteetit vuodenajan ja hintarajauksen perusteella
            Console.WriteLine("Lisää enimmäishinta:")

            const string url = "http://open-api.myhelsinki.fi/v1/place/2";
            string urlParams = "";

            Tapahtumat tapahtuma = await ApiHelper.RunAsync<Tapahtumat>(url, urlParams);

            Console.WriteLine(tapahtuma.name.fi.ToString());
            Console.WriteLine(tapahtuma.info_url.ToString());
            Console.WriteLine(tapahtuma.modified_at.Ticks.ToString());
            Console.WriteLine(tapahtuma.opening_hours.hours[1].weekday_id.ToString());

        }

    }
}


