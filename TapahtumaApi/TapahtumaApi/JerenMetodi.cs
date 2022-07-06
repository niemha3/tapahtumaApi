using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static TapahtumaApi.Program;
using System.Linq;
using System.Threading;

namespace TapahtumaApi
{

    class Jere
    {
        public static void MenoMetodi()
        {
            Console.Clear();
            Console.ForegroundColor
            = ConsoleColor.Magenta;
            for (int i = 0; i < 28; i++)
            {
                Console.Write("*");
                Thread.Sleep(22);
            }
            Console.ForegroundColor
            = ConsoleColor.Cyan;
            Console.WriteLine("\n\tHYVÄÄ JATKOA");
            Console.ForegroundColor
            = ConsoleColor.Magenta;
            for (int i = 0; i < 28; i++)
            {
                Console.Write("*");
                Thread.Sleep(22);
            }
        }
        public static async Task JerenMetodi()
        {
            const string url = "http://open-api.myhelsinki.fi/v1/places/" ;
            string urlParams = "?language-filter=fi";
            /*Eventlist tapahtumaList = await ApiHelper.RunAsync<Eventlist>(url, urlParams);
            foreach (Datum o in tapahtumaList.data)
            {

            }*/
            Rootobject tapahtumaPaikat = await ApiHelper.RunAsync<Rootobject>(url, urlParams);

            var jolo = (from o in tapahtumaPaikat.data where o.source_type.name == "Allas"  select o).ToList();
            foreach (var i in jolo)
            {  

                
                Console.WriteLine(i.location);
            }
          


        }

    }
}
