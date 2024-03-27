using LibrarieModele;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NivelStocareDate
{
    public class GestionareLiveziFisiereText
    {
        private const int NR_MAX_LIVEZI = 100;
        private string numeFisierC;

        public GestionareLiveziFisiereText(string numeFisier)
        {
            this.numeFisierC = numeFisier;
            Stream streamFisierText = File.Open(numeFisierC, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void AddLivezi(Livada livada)
        {
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisierC, true))
            {
                streamWriterFisierText.WriteLine(livada.ConversieLaSir_PentruFisier());
            }
            Console.WriteLine("Livada adaugata cu succes!");
        }

        public Livada[] GetLivada(out int nrlivezi)
        {
            Livada[] livezi = new Livada[NR_MAX_LIVEZI];
            using (StreamReader streamReader = new StreamReader(numeFisierC))
            {
                string linieFisier;
                nrlivezi = 0;

                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    livezi[nrlivezi++] = new Livada(linieFisier);
                }
            }

            Array.Resize(ref livezi, nrlivezi);
            return livezi;
        }

        public void AfisareLiveziAceasiSuprafata(double cautare)
        {
            Console.WriteLine($"\nLivezile cu aceeasi suprafata '{cautare}' sunt:");

            using (StreamReader streamReader = new StreamReader(numeFisierC))
            {
                string linieFisier;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Livada livada = new Livada(linieFisier);
                    if (livada.suprafata == cautare)
                    {
                        Console.WriteLine(livada.ConversieLaSir_PentruFisier());
                    }
                }
            }
        }
    }

}
