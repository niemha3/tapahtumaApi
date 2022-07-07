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
            while (jeppis2 == true) // Pyörii kunnes jeppis2 on false eli osuman tullessa
            {
                Console.Clear();
                try {

                    Console.WriteLine("\n\n\t\tTervetuloa aktiviteettihakuun!\n");

                    Console.WriteLine("\n\n\t\tLisää hakusana aktiviteetille ja paina Enter:\n");
                    string haeLaji = Console.ReadLine();
                    // aktiviteetit hakusanan perusteella
                    Console.WriteLine("\n");

                    const string url = "http://open-api.myhelsinki.fi/v1/activities/";
                    string urlParams = "";

                    ActivitiesList activity = await ApiHelper.RunAsync<ActivitiesList>(url, urlParams);             //mistä haetaan

                    var action1 = activity.data.Where(esko => esko.name.fi != null); // poistaa mahdolliset Nullit
                    var action = action1.Where(esko => esko.name.fi.ToLower().Contains(haeLaji));                               //lambda-haku
                    


                    if (action != null)// osuma löytyy
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

                        }
                       
                    }
                    // Osuma ei löydy
                    if (jeppis2 == true) {
                       
                        Console.WriteLine("\n\n\t\tSyöteellä ei löydy mitään\n\n" +
                            "\t\tPaina nappia jatkaaksesi hakua");
                        Console.ReadKey();
                    }
                }
                catch { continue; }
                



            }
        }
    }

}




