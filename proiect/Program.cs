using LibrarieModele;
using NivelStocareDate;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect
{
    internal class Program
    {
       


        static void Main(string[] args)
        {
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;


            GestionarePomiFisiereText adminPomi = new GestionarePomiFisiereText(numeFisier);

            Pom pomNou = new Pom ();
            int nrpomi = 0;

            Pom[] pomi = adminPomi.GetPomi(out nrpomi);
    
            string optiune;
            do
            {
                Console.WriteLine("C. Introduceti detalii pentru pom");
                Console.WriteLine("A. Afisati pomi introdusi");

                Console.WriteLine("W. Salvare pom in fisier");
                Console.WriteLine("S. Cautare pomi de acelasi tip");
                Console.WriteLine("X. Iesire din program");

                Console.WriteLine("Alegeti optiunea: ");
                optiune = Console.ReadLine();

                switch (optiune.ToUpper())
                {
                    case "C":
                        pomNou = CitirePomTastatura();
                        break; 
                    case "A":
                        pomi = adminPomi.GetPomi (out nrpomi);
                        GestionarePomi.AfisarePomiIntrodusi(pomi);
                        break;
                    case "S":
                        Console.WriteLine("Introduceti tipul de pom cautat:");
                        string tipCautat = Console.ReadLine();
                        GestionarePomi.AfisarePomiDeAcelasiTip(pomi, tipCautat);
                        break;
                    case "W":
                        adminPomi.AddPomi(pomNou);
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

        public static Pom CitirePomTastatura()
        {
            Console.WriteLine("Introduceti tipul de pom: ");
            string tip= Console.ReadLine();

            Console.WriteLine("Introduceti cantitatea de fructe: ");
            int cantitate_fructe = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Introduceti anul plantari:");
            int  anul_plantari =Convert.ToInt32( Console.ReadLine());

            Pom pom= new Pom(tip, cantitate_fructe, anul_plantari);

            return pom;
        }

        public static void AfisarePom(Pom pom)
        {
            string InfoPom = string.Format($"Tipul de pom: {pom.tip} \n Cantitatea de fructe: {pom.cantitate_fructe} \n Anul plantarii: {pom.anul_plantarii}");
            Console.WriteLine(InfoPom);
        }
        public static void AfisarePomi(Pom[] pomi)
        {
            Console.WriteLine("Pomi sunt:");
            foreach (Pom pom in pomi)
            {
                string InfoPom = pom.InfoPom();
                Console.WriteLine(InfoPom);
            }
        }
    }
}


