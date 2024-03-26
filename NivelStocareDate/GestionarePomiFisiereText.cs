using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;

namespace NivelStocareDate
{
    public class GestionarePomiFisiereText
    {
        
            private const int NR_MAX_POMI = 100;
            private string numeFisier;

            public GestionarePomiFisiereText(string numeFisier)
            {
                this.numeFisier = numeFisier;
                Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
                streamFisierText.Close();
            }
        public void AddPomi(Pom pom)
        {
          
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(pom.ConversieLaSir_PentruFisier());
            }
        }

        public Pom[] GetPomi(out int nrPomi)
        {
            Pom[] pomi = new Pom[NR_MAX_POMI];

           
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                nrPomi = 0;

                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    pomi[nrPomi++] = new Pom(linieFisier);
                }
            }

        
            Array.Resize(ref pomi, nrPomi);

            return pomi;
        }
     

    }
}
