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
            string numeFisierLivezi = ConfigurationManager.AppSettings["NumeFisierC"];

            string locatieFisierSolutie = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

            string caleCompletaFisier = locatieFisierSolutie+"\\"+numeFisier;
            string caleCompletaFisierLivezi = locatieFisierSolutie + "\\" + numeFisierLivezi;

            GestionarePomiFisiereText adminPomi = new GestionarePomiFisiereText(numeFisier);
            GestionareLiveziFisiereText adminLivezi = new GestionareLiveziFisiereText(numeFisierLivezi);

            Pom pomNou = new Pom ();
            int nrpomi = 0;

            Livada livadaNoua = new Livada ();
            int nrlivezi= 0;

            Pom[] pomi = adminPomi.GetPomi(out nrpomi);
            Livada[] livezi = adminLivezi.GetLivada(out nrlivezi);


            string[] words = ReadWordsFromFile("pomi.txt");

            string[][] wordArray = SplitWordsByFirstLetter(words);




            string optiune;
            do
            {
                Console.WriteLine("C. Introduceti detalii pentru pom");
                Console.WriteLine("A. Afisati pomi introdusi");
                Console.WriteLine("W. Salvare pom in fisier");
                Console.WriteLine("S. Cautare pomi de acelasi tip");
                Console.WriteLine("CL. Introduceti detalii pentru livada");
                Console.WriteLine("AL. Afisati livezile introduse");
                Console.WriteLine("WL. Salvare livada in fisier");
                Console.WriteLine("SL. Cautare livezi cu aceasi suprafata");
                Console.WriteLine("T. Afisare tipuri de pomi");
                Console.WriteLine("X. Iesire din program");

                Console.WriteLine("Alegeti optiunea: ");
                optiune = Console.ReadLine();

                switch (optiune.ToUpper())
                {
                    case "C":
                        pomNou = CitirePomTastatura();
                        break;
                    case "CL":
                        livadaNoua = CitireLivadaTastatura();
                        break;
                    case "A":
                        pomi = adminPomi.GetPomi(out nrpomi);
                        AfisarePomiIntrodusi(pomi);
                        //AfisarePom(pomNou);
                        break;
                    case "AL":
                        livezi = adminLivezi.GetLivada(out nrlivezi);
                        AfisareLiveziIntroduse(livezi);
                        AfisareLivada(livadaNoua);
                        break;
                    case "S":
                        Console.WriteLine("Introduceti tipul de pom cautat:");
                        string tipCautat = Console.ReadLine();
                        adminPomi.AfisarePomiDeAcelasiTip(tipCautat);
                        break;
                    case "SL":
                        if (double.TryParse(Console.ReadLine(), out double cautareSuprafata))
                            adminLivezi.AfisareLiveziAceasiSuprafata(cautareSuprafata);
                        else
                            Console.WriteLine("Suprafata introdusa nu este valida.");
                        break;
                    case "W":
                        adminPomi.AddPomi(pomNou);
                        break;
                    case "T":
                         
                       DisplayWordArray(wordArray);

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
        public static Livada CitireLivadaTastatura()
        {
            Console.WriteLine("Introduceti suprafata livezi: ");
            double suprafata = Convert.ToDouble(Console.ReadLine());
          

            Console.WriteLine("Introduceti id-ul livezi: ");
            string id_livada = Console.ReadLine();

            Livada livada = new Livada(suprafata, id_livada);

            return livada;
        }

        public static void AfisarePom(Pom pom)
        {
            string InfoPom = string.Format($"Tipul de pom: {pom.tip ?? "NECUNOSCUT"}, Cantitatea de fructe: {pom.cantitate_fructe} , Anul plantarii: {pom.anul_plantarii}");
            Console.WriteLine(InfoPom);
        }
        public static void AfisareLivada(Livada livada)
        {
            string InfoLivada = string.Format( $"Suprafata livezii: {livada.suprafata} , ID livezi: {livada.id_livada ?? "NECUNOSCUT"}");
            Console.WriteLine(InfoLivada);
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
        public static void AfisareLiveziIntroduse(Livada[] livezi)
        {
            if (livezi.Length == 0)
            {
                Console.WriteLine("Nu exista livezi introduse inca.");
                return;
            }

            Console.WriteLine("\nLivezile introduse:");
            foreach (var livada in livezi)
            {
                Console.WriteLine(livada.InfoLivada());
            }
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


        static string[] ReadWordsFromFile(string filename)
        {
            try
            {
                return File.ReadAllLines(filename);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Eroare la citirea din fisier: {ex.Message}");
                return new string[0];
            }
        }

        static string[][] SplitWordsByFirstLetter(string[] words)
        {
            string[][] wordArray = new string[26][]; // Un tablou de 26 de elemente pentru cele 26 de litere ale alfabetului

            for (int i = 0; i < 26; i++)
            {
                wordArray[i] = new string[0]; // Inițializăm fiecare componentă a tabloului cu un tablou gol
            }

            foreach (string word in words)
            {
                if (!string.IsNullOrEmpty(word))
                {
                    char firstLetter = char.ToUpper(word[0]); // Obținem prima literă și o convertim la majusculă

                    int index = firstLetter - 'A'; // Calculăm indexul în tabloul wordArray folosind codul ASCII al literei

                    // Adăugăm cuvântul la tabloul corespunzător primei litere
                    wordArray[index] = AddWordToArray(wordArray[index], word);
                }
            }

            return wordArray;
        }

        static string[] AddWordToArray(string[] array, string word)
        {
            Array.Resize(ref array, array.Length + 1); // Mărim tabloul cu o poziție
            array[array.Length - 1] = word; // Adăugăm cuvântul la ultima poziție
            return array;
        }

        static void DisplayWordArray(string[][] wordArray)
        {
            for (int i = 0; i < wordArray.Length; i++)
            {
                char letter = (char)('A' + i); // Obținem litera corespunzătoare indexului
                Console.WriteLine($"Cuvintele care încep cu litera '{letter}':");
                foreach (string word in wordArray[i])
                {
                    Console.WriteLine(word);
                }
                Console.WriteLine();
            }
        }
    }
}


