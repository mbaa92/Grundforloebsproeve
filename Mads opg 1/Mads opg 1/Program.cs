using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mads_opg_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mads' opgave 1

            string ord = "solution"; 
            string gaet; //holder styr på brugerens gæt
            

            Console.WriteLine("Gæt det hemmelige ord du har 5 forsøg i alt");
            for (int i = 0; i < 5; i++)                       
            {
                
                Console.WriteLine("Indtast dit gæt nr. {0} og afslut med enter", i+1);
                gaet=Console.ReadLine().ToLower();

                if (gaet == ord)
                {
                    Console.WriteLine("Godt gået du har gættet rigtig på {0}. forsøg og får derfor {1} point", i+1, 100-i*20); 
                    i = i + 5;
                }
                else if (gaet != ord && i==4)
                {
                    Console.WriteLine("Du har brugt alle 5 forsøg, programmet vil derfor afslutte");
                }

            }
            Console.ReadKey();

        }
    }
}
