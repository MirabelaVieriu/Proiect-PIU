using LibrarieModele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Pom[] pomi = new Pom[0]; 

            string optiune;
            do
            {
                Console.WriteLine("C. Introduceti detalii pentru pomi");
                Console.WriteLine("A. Afisati pomi introdusi");
                Console.WriteLine("S. Cautare pomi de acelasi tip");
                Console.WriteLine("X. Iesire din program");

                Console.WriteLine("Alegeti optiunea: ");
                optiune = Console.ReadLine();

                switch (optiune.ToUpper())
                {
                    case "C":
                        pomi = IntroducereDetaliiPomi();
                        break;
                    case "A":
                        AfisarePomiIntrodusi(pomi);
                        break;
                    case "B":
                         string tipCautat=Console.ReadLine();
                         Afisarepomideacelasitip(pomi, tipCautat);
                        break;   
                    case "X":
                        return;
                    default:
                        Console.WriteLine("Optiune invalida. Va rugam sa alegeti din nou.");
                        break;
                }
          
            } while (optiune.ToUpper()!= "X");

            Console.ReadKey();
        }
        

        public static Pom[] IntroducereDetaliiPomi()
        {
            Console.Write("Introduceti numarul de pomi: ");
            if (!int.TryParse(Console.ReadLine(), out int numarPomi) || numarPomi <= 0)
            {
                Console.WriteLine("Va rugam sa introduceti un numar valid de pomi.");
                return new Pom[0]; 
            }

            Pom[] pomi = new Pom[numarPomi];

            for (int i = 0; i < numarPomi; i++)
            {
                Console.WriteLine($"Introduceti detalii pentru pomul {i + 1}:");
                Console.Write("Tipul de pom: ");
                string tip = Console.ReadLine();

                Console.Write("Cantitatea de fructe: ");
                if (!int.TryParse(Console.ReadLine(), out int cantitateFructe))
                {
                    Console.WriteLine("Va rugam sa introduceti o valoare valida pentru cantitatea de fructe.");
                    return new Pom[0]; 
                }

                Console.Write("Anul plantarii: ");
                if (!int.TryParse(Console.ReadLine(), out int anulPlantarii))
                {
                    Console.WriteLine("Va rugam sa introduceti un an valid pentru plantare.");
                    return new Pom[0];
                }

                pomi[i] = new Pom(tip, cantitateFructe, anulPlantarii);
            }

            return pomi;
        }

        public static void AfisarePomiIntrodusi(Pom[] pomi)
        {
            if (pomi.Length == 0)
            {
                Console.WriteLine("Nu exista pomi introdusi inca.");
                return;
            }

            Console.WriteLine("\nPomi introdusi:");
            foreach (var pom in pomi)
            {
                Console.WriteLine(pom.Info());
            }
        }

        public static void Afisarepomideacelasitip(Pom[] pomi, string tipCautat)
        {
            
           Console.WriteLine($"\nPomi de acelasi tip '{tipCautat}' sunt:");

            foreach (var pom in pomi)
            {
                if (pom.tip == tipCautat)
                {
                    Console.WriteLine(pom.Info());
                }
            }
        }
    }
}


