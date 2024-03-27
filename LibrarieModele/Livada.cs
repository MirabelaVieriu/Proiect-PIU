using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele

{
    public class Livada
    {
        private const int SUPRAFATA = 0;
        private const int ID_LIVADA = 1;
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        public double suprafata { get; set; }
        public string id_livada { get; set; }

        public Livada(double Suprafata, string ID_livada)
        {
            this.suprafata = Suprafata;
            this.id_livada = ID_livada;

        }
        public Livada()
        {
            
        }
        public Livada(string linieFisier)
        {
            string[] dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            this.suprafata = Convert.ToDouble((dateFisier[SUPRAFATA]));
            this.id_livada = dateFisier[ID_LIVADA];
        }
        public string ConversieLaSir_PentruFisier()
        {
            string obiectLivadaPentruFisier = string.Format("{1}{0}{2}{0}",
                SEPARATOR_PRINCIPAL_FISIER,
                suprafata,
                (id_livada ?? " NECUNOSCUT "));
            return obiectLivadaPentruFisier;
        }
       
        public string InfoLivada()
        {
            string info = $"Suprafata livezii: {suprafata} , ID livezi: {id_livada ?? "NECUNOSCUT"}";
            return info;

        }

    }
}
