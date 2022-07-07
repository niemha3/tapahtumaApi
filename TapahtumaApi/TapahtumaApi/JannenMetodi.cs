using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static TapahtumaApi.Program;
using System.Linq;
using System.Threading;

namespace TapahtumaApi
{
    class Janne
    {

        public static async Task JannenMetodi()
        {
            bool jeppis2 = true;
            do
            {


                Console.WriteLine("Tervetuloa aktiviteettihakuun!\n");

                Console.WriteLine("Lisää hakusana aktiviteetille ja paina Enter:\n");
                string haeLaji = Console.ReadLine();
                // aktiviteetit hakusanan perusteella
                Console.WriteLine("\n");

                const string url = "http://open-api.myhelsinki.fi/v1/activities/";
                string urlParams = "";

                ActivitiesList activity = await ApiHelper.RunAsync<ActivitiesList>(url, urlParams);             //mistä haetaan

                var action1 = activity.data.Where(esko => esko.name.fi != null);


                var action = action1.Where(esko => esko.name.fi.ToLower().Contains(haeLaji));                               //lambda-haku
                var action2 = action1.Where(esko => !esko.name.fi.ToLower().Contains(haeLaji));
                bool jeppis = true;

                if (action2 != null) { jeppis = false; }


                while (true)

                {


                    foreach (var item in action)

                    {
                        jeppis2 = false;

                        //haluttu tulostus
                        Console.WriteLine("Nimi: " + item.name.fi + "\n");
                        Console.WriteLine("Kuvaus: " + item.description.body.Replace("<br>", "").Replace("<p>", "")
                        .Replace("<span>", "").Replace("<br />", "").Replace("</span>", "").Replace("</p>", "").Replace("&nbsp;", ""));
                        Console.WriteLine("Osoite: " + item.location.address.street_address + "\n");
                        Console.WriteLine("Lisätietoja: " + item.info_url + "\n");
                        Console.WriteLine("Kesto: " + item.where_when_duration.duration + "\n");


                        Console.WriteLine("\n*****************************************************************************************\n");
                        break;
                    }
                    break;

                }
          
                if (jeppis == false) { Console.WriteLine("Virhe\n"); }
                break;
            }
            while (jeppis2 == true);
        }
                    
                


            }
        }
    




