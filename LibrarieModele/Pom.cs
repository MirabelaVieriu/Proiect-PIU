using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Pom
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const char SEPARATOR_SECUNDAR_FISIER = ' ';
        private const int TIP = 0;
        private const int CANTITATE_FRUCTE = 1;
        private const int ANUL_PLANTARI = 2;

        public string tip { get; set; }
        public int cantitate_fructe { get; set; }
        public int anul_plantarii { get; set; }
        public Pom(string Tip, int Cantitate_fructe, int Anul_plantarii)
        {
            this.tip = Tip;
            this.cantitate_fructe = Cantitate_fructe;
            this.anul_plantarii = Anul_plantarii;
        }
        public Pom(string linieFisier)
        {
            string[] dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

      
            this.tip = dateFisier[TIP];
            this.cantitate_fructe = Convert.ToInt32(dateFisier[CANTITATE_FRUCTE]);
            this.anul_plantarii = Convert.ToInt32(dateFisier[ANUL_PLANTARI]);
        }

        public Pom()
        {
        }

        public string ConversieLaSir_PentruFisier()
        {
            string obiectPomPentruFisier = string.Format("{1}{0}{2}{0}{3}",
                SEPARATOR_PRINCIPAL_FISIER,
                (tip ?? " NECUNOSCUT "),
                cantitate_fructe,
                anul_plantarii);

            return obiectPomPentruFisier;
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
        
        public string InfoPom()
        {
            string info = $"Tipul de pom: {tip ?? "NECUNOSCUT"} , Cantitatea de fructe: {cantitate_fructe} , Anul plantarii: {anul_plantarii}";
            return info;
        }

       
    }

}
