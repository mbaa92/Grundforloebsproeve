using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mads_opg_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mads opgave 5
            string Valg; // Holder styr på brugerens menuvalg

            int ArbejdsTimer =0; //holder styr på antal time for de forskellige behandlinger
            int BenTimer=0;
            int SkulderTimer = 0;
            
            int Total; //skal holde styr på prisen i alt. Værdi gives i regning


            do
            {
                Console.WriteLine("--------------------Velkommen til Klinik for Fysioterapi--------------------");
                Console.WriteLine("Tryk:");
                Console.WriteLine("A\tfor\tArbejdsrelaterede skader\tPris:\t500kr/time");
                Console.WriteLine("B\tfor\tBen-skader\t\t\tPris:\t450kr/time");
                Console.WriteLine("S\tfor\tSpændinger i skulderen\t\tPris:\t550kr/time");
                Console.WriteLine("R\tfor\tat vise klientens regning");
                Console.WriteLine("Q\tfor\tat afslutte programmet");


                Valg = Console.ReadLine().ToUpper();

                switch (Valg)
                {
                    case "A":
                        Console.WriteLine("Indtast antallet af timer klienten har fået behandling for arbejdsrelaterede skader");
                        ArbejdsTimer=Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Klienten skal betale {0}*500={1} kr", ArbejdsTimer, ArbejdsTimer*500);
                        Console.WriteLine("Tryk på en tast for at komme tilbage til hovemenuen");
                        Console.ReadKey();
                        Console.Clear();

                        break;
                    case "B":
                        Console.WriteLine("Indtast antallet af timer klienten har fået behandling for ben-skader");
                        BenTimer = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Klienten skal betale {0}*450={1} kr", BenTimer, BenTimer * 450);
                        Console.WriteLine("Tryk på en tast for at komme tilbage til hovemenuen");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "S":
                        Console.WriteLine("Indtast antallet af timer klienten har fået behandling for spændinger i skuldrene");
                        SkulderTimer = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Klienten skal betale {0}*550={1} kr", SkulderTimer, SkulderTimer * 550);
                        Console.WriteLine("Tryk på en tast for at komme tilbage til hovemenuen");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "R":
                        Total = ArbejdsTimer * 500 + BenTimer * 450 + SkulderTimer * 550;
                        Console.WriteLine("Klientens regning:");
                        Console.WriteLine("--------------------------------------------------------------------------");
                        Console.WriteLine("Arbejdsrelaterede skader:\t{0} timer a 500 kr\t{1} kr",ArbejdsTimer,ArbejdsTimer*500);
                        Console.WriteLine("Ben-skader:\t\t\t{0} timer a 450 kr\t{1} kr", BenTimer,BenTimer * 450);
                        Console.WriteLine("Spændinger i skulderen:\t\t{0} timer a 550 kr\t{1} kr", SkulderTimer,SkulderTimer * 550);
                        Console.WriteLine("--------------------------------------------------------------------------");
                        Console.WriteLine("Pris ialt:\t\t\t\t\t\t{0} kr",Total);
                        Console.WriteLine("\nTryk på en tast for at komme tilbage til hovemenuen");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "Q":
                        Console.WriteLine("Du har valgt at afslutte programmet. Tryk på en tast for at afslutte");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Din indtastning '{0}' var ikke blandt muligheder. Tryk på en tast for at komme tilbage til menuen", Valg);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }

            } while (Valg != "Q");


        }
    }
}
