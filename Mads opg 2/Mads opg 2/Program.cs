using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mads_opg_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mads opgave 2

            string citat;
            bool check = true; //til at stoppe loopet

            do
            {
                Console.WriteLine("Indtast et citat, der lever op til følgende krav");
                Console.WriteLine("1) Citatet skal min. indeholde 20 tegn og maks. indeholde 50 bogstaver");
                Console.WriteLine("2) Citatet skal enten starte med bogstavet 'D' eller ende på bogstave 'T'");
                citat=Console.ReadLine().ToUpper();

                if (citat.Length >= 20 && citat.Count(char.IsLetter) <= 50) //tester første krav
                {
                    if (citat.StartsWith("D") && !citat.EndsWith("T")) //tester andet krav
                    {
                        Console.WriteLine("Det lykkedes, tryk på en tast for at afslutte");
                        check = false;
                        Console.ReadKey();
                    }
                    else if (!citat.StartsWith("D") && citat.EndsWith("T")) //tester andet krav
                    {
                        Console.WriteLine("Det lykkedes, tryk på en tast for at aflutte");

                        check = false;
                        Console.ReadKey();
                    }

                }
                Console.Clear();
            } while (check);
            
        }
    }
}
