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
            Console.WriteLine("\n\n\n\n\n\n");
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
            Console.WriteLine("\n\n\n\n\n\n");
        }
        public static async Task JerenMetodi()
        {
            const string url = "http://open-api.myhelsinki.fi/v1/places/";
            string urlParams = "";
            PlacesList tapahtumaPaikat = await ApiHelper.RunAsync<PlacesList>(url, urlParams);
            int valinta;
            do
            {
                Console.Clear();

                Console.WriteLine("\n\n\t\t\tHae tietoa urheilumahdollisuuksista\n\n" +
                    "\t1. Golf\n" +
                    "\t2. Uinti\n" +
                    "\t3. Hyvän börstan juominen/hankinta\n\n" +
                    "\t4. Jos haluat palata takaisin alkuun"
                    );
                valinta = Convert.ToInt32(Console.ReadLine());
                switch (valinta)
                {
                    case 1:


                        var golf = from o in tapahtumaPaikat.data where o.name.fi.ToLower().Contains("golf")
                                   select o;
                        var antifrisbee = from o in golf where !o.name.fi.ToLower().Contains("frisbee") select o;
                        var antiMiniGolf = from o in antifrisbee where !o.name.fi.ToLower().Contains("mini") select o;
                        var antiHohtoGolf = from o in antiMiniGolf where !o.name.fi.ToLower().Contains("hohto") select o;

                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Clear();
                Console.WriteLine("*********************************************************");
                        
                foreach (var i in antiHohtoGolf)
                {
                            
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\t\t" + i.name.fi + "\n");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("\t" + i.location.address.street_address + "\n\t");
                    Console.ForegroundColor = ConsoleColor.White;
                    var stringi = i.description.body;
                    var kalle = string.Join(Environment.NewLine, stringi.Split()
                        .Select((word, index) => new { word, index }).GroupBy(x => x.index / 6)
                        .Select(grp => string.Join(" ", grp.Select(x => x.word)))); /// GOOGLE TEKI 
                    Console.WriteLine(kalle+ "\n");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine(i.info_url);
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\n*******************************************************\n");
                    Console.ForegroundColor = ConsoleColor.White;
                
                }
                        Console.ReadKey();
                        break;
                        
                    case 2:
                        Console.Clear();
                        
                        var uinti = from o in tapahtumaPaikat.data where o.name.fi.ToLower().Contains("uima") select o;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("*********************************************************");

                        foreach (var i in uinti)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\t\t" + i.name.fi + "\n");
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("\t" + i.location.address.street_address + "\n\t");
                            
                            Console.ForegroundColor = ConsoleColor.White;
                            var stringi = i.description.body;
                            var kalle = string.Join(Environment.NewLine, stringi.Split()
                                .Select((word, index) => new { word, index }).GroupBy(x => x.index / 6)
                                .Select(grp => string.Join(" ", grp.Select(x => x.word)))); /// GOOGLE TEKI 
                            Console.WriteLine(kalle+ "\n");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine(i.info_url);
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("\n*******************************************************\n");
                            Console.ForegroundColor = ConsoleColor.White;

                        }
                        Console.ReadKey();
                        break;
                       
                        
                    case 3:
                        Console.Clear();

                        var hiihto = from o in tapahtumaPaikat.data where o.name.fi.ToLower().Contains("panimo") ||
                                     o.name.fi.ToLower().Contains("pien") || o.name.fi.ToLower().Contains("kalja") ||
                                     o.name.fi.ToLower().Contains("olut") || o.name.fi.ToLower().Contains("brew") || 
                                     o.name.fi.ToLower().Contains("beer") select o;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("*********************************************************");

                        foreach (var i in hiihto)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\t\t" + i.name.fi + "\n");
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("\t" + i.location.address.street_address + "\n\t");

                            Console.ForegroundColor = ConsoleColor.White;
                            var stringi = i.description.body;
                            var kalle = string.Join(Environment.NewLine, stringi.Split()
                                .Select((word, index) => new { word, index }).GroupBy(x => x.index / 6)
                                .Select(grp => string.Join(" ", grp.Select(x => x.word)))); /// GOOGLE TEKI 
                            Console.WriteLine(kalle + "\n");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine(i.info_url);
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("\n*******************************************************\n");
                            Console.ForegroundColor = ConsoleColor.White;

                        }
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("\n\n\t\t\t\tPalaa takaisin \n\n\t\t\t\t  painamalla ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        string textToEnter = @"

     /$$$$$$$$ /$$   /$$ /$$$$$$$$ /$$$$$$$$ /$$$$$$$ 
    | $$_____/| $$$ | $$|__  $$__/| $$_____/| $$__  $$
    | $$      | $$$$| $$   | $$   | $$      | $$  \ $$
    | $$$$$   | $$ $$ $$   | $$   | $$$$$   | $$$$$$$/
    | $$__/   | $$  $$$$   | $$   | $$__/   | $$__  $$
    | $$      | $$\  $$$   | $$   | $$      | $$  \ $$
    | $$$$$$$$| $$ \  $$   | $$   | $$$$$$$$| $$  | $$
    |________/|__/  \__/   |__/   |________/|__/  |__/
                                                           
                ";
                Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));
                Thread.Sleep(50);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey();
                        Console.Clear();
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
            while (valinta != 4);



        }

    } }


