using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mads_opg_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mads opgave 3

            int SkønAntal = 0; //alle fire holder løbende styr på antallet af bøger i hver genre
            int FagAntal = 0;
            int KunstAntal = 0;
            int GeoAntal = 0;

            int size;

            string genre;

            string[] books;

            Console.WriteLine("Indtast antal af bøger der skal registreres");
            size = Convert.ToInt32(Console.ReadLine());
            books = new string[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Indtast titlen på bog {0}", i+1);
                books[i] = Console.ReadLine();

                Console.WriteLine("Vælg nr. {0} bogs genre", i+1);
                Console.WriteLine("S\t\t for Skønlitteratur");
                Console.WriteLine("F\t\t for Faglitteratur");
                Console.WriteLine("K\t\t for Kunstbøger");
                Console.WriteLine("G\t\t for Geografibøger");
                genre = Console.ReadLine().ToUpper();
                switch (genre)
                {
                    case "S":
                        SkønAntal++;
                        break;
                    case "F":
                        FagAntal++;
                        break;
                    case "K":
                        KunstAntal++;
                        break;
                    case "G":
                        GeoAntal++;
                        break;
                }                                              
                 
                Console.Clear();
            }
            
            Array.Sort(books);
            Console.WriteLine("Listen af registrerede bøger i alfabetisk rækkefølge:");
            foreach (string book in books) 
            {
                Console.WriteLine(book);
                Console.WriteLine("---------------------");
            }
            Console.WriteLine("\nAntallet af bøger i de forskellige genre");
            Console.WriteLine("Skønlitteratur:\t\t{0} bøger", SkønAntal);
            Console.WriteLine("Faglitteratur:\t\t{0} bøger", FagAntal);
            Console.WriteLine("Kunstbøger:\t\t{0} bøger", KunstAntal);
            Console.WriteLine("Geografibøger:\t\t{0} bøger", GeoAntal);
            




            Console.ReadKey();
           

        }
    }
}
