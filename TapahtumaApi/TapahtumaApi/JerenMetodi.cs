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
      
    }
}
