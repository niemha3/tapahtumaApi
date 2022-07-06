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
            const string url = "http://open-api.myhelsinki.fi/v1/places/";
            string urlParams = "";
            Rootobject tapahtumaPaikat = await ApiHelper.RunAsync<Rootobject>(url, urlParams);
            int valinta;
            do
            {
                Console.Clear();

                Console.WriteLine("Hae tietoa urheilumahdollisuuksista\n" +
                    "1. Golf\n" +
                    "2. Uinti\n" +
                    "3. Hiihto\n" +
                    "4. Jos haluat palata takaisin alkuun"
                    );
                valinta = Convert.ToInt32(Console.ReadLine());
                switch (valinta)
                { 
                case 1:
                
                
                var golf = from o in tapahtumaPaikat.data where o.name.fi.Contains(" Golf") select o;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("*********************************************************");

                foreach (var i in golf)
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
                        
                        var uinti = from o in tapahtumaPaikat.data where o.name.fi.Contains("uima") select o;
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

                        var hiihto = from o in tapahtumaPaikat.data where o.name.fi.Contains("hiihto") || o.name.fi.Contains("Latu") select o;
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
                        Console.Read();


                        break;
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\t\t|||||||||||||||||||||||");
                        Console.WriteLine("\t\t|         !           |");
                        Console.WriteLine("\t\t|    VÄÄRÄ VALINTA    |");
                        Console.WriteLine("\t\t|         !           |");
                        Console.WriteLine("\t\t|||||||||||||||||||||||\n\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            }
            while (valinta != 4);



        }

    } }


