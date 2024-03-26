using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;


namespace NivelStocareDate
{
    public class GestionarePomi

    {

        Pom[] pomi = new Pom[0];
        private const int NR_MAX_POM= 50;
        private Pom[] pomi1;
        private int nrpomi;

        public GestionarePomi()
        {
           pomi1 = new Pom[NR_MAX_POM];
            nrpomi = 0;
        }

        public void Addpom(Pom pom)
        {
            pomi1[nrpomi] = pom;
            nrpomi++;
        }

        public Pom[] GetPomi(out int nrpomi)
        {
            nrpomi= this.nrpomi;
            return pomi1;
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
                Console.WriteLine(pom.InfoPom());
            }
        }

        public static void AfisarePomiDeAcelasiTip(Pom[] pomi, string tipCautat)
        {

            Console.WriteLine($"\nPomi de acelasi tip '{tipCautat}' sunt:");

            foreach (var pom in pomi)
            {
                if (pom.tip == tipCautat)
                {
                    Console.WriteLine(pom.InfoPom());
                }
            }
        }

     
    }
}
