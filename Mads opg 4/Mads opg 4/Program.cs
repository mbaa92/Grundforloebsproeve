using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mads_opg_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mads opgave 4

            
            string FartGraenseValg;

            int Hastighed;
            int FartOver; //holder styr på hvor meget der er kørt for stærkt
            

            Console.WriteLine("Dette program udregner størrelsen af fartbøder");

           
            Console.WriteLine("Vælg fartgrænsen, tryk:");
            Console.WriteLine("1\t\tfor 40 km/t");
            Console.WriteLine("2\t\tfor 50 km/t");
            Console.WriteLine("3\t\tfor 60 km/t");
            FartGraenseValg = Console.ReadLine();
            Console.WriteLine("Indtast hvor hurtigt der blev kørt i km/t");
            Hastighed=Convert.ToInt32(Console.ReadLine());

            switch(FartGraenseValg)
            {
                case "1":
                    if (Hastighed > 40)
                    {
                        FartOver = Hastighed - 40;

                        Console.WriteLine("Billisten har kørt {0}-40={1} km/t for stærkt og skal derfor betale {1}*200={2} kr",Hastighed,FartOver,FartOver*200);
                    }
                    else
                    {
                        Console.WriteLine("Der blev kørt {0} km/t i en 40 km/t zone, hvilket ikke er for stærkt, og der er derfor ikke nogen bøde", Hastighed);
                    }
                    break;
                case "2":
                    if (Hastighed > 50)
                    { 
                        FartOver = Hastighed - 50;

                        Console.WriteLine("Billisten har kørt {0}-50={1} km/t for stærkt og skal derfor betale {1}*150={2} kr", Hastighed, FartOver, FartOver * 150);
                    }
                    else
                    {
                        Console.WriteLine("Der blev kørt {0} km/t i en 50 km/t zone, hvilket ikke er for stærkt, og der er derfor ikke nogen bøde", Hastighed);
                    }
                    break;
                case "3":
                    if (Hastighed > 60)
                    {
                        FartOver = Hastighed - 60;

                        Console.WriteLine("Billisten har kørt {0}-60={1} km/t for stærkt og skal derfor betale {1}*120={2} kr", Hastighed, FartOver, FartOver * 120);
                    }
                    else
                    {
                        Console.WriteLine("Der blev kørt {0} km/t i en 60 km/t zone, hvilket ikke er for stærkt, og der er derfor ikke nogen bøde", Hastighed);
                    }
                    break;
                default:
                    Console.WriteLine("Dit valg af fartgrænse var ikke blandt de mulige, genstart programmet og prøv igen");
                    break;
            }
            Console.ReadKey();
        }
    }
}
