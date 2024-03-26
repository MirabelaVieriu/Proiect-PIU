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
        public Livada(string linieFisier)
        {
            string[] dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            this.suprafata = double.Parse(dateFisier[SUPRAFATA]);
            this.id_livada = dateFisier[ID_LIVADA];
        }


        public string Info()
        {
            string info = $"Suprafata livezii: {suprafata} /n ID livezi: {id_livada}";
            return info;
        }

    }
}
