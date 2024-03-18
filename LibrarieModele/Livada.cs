using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele

{
    public class Livada
    {
        public double suprafata { get; set; }
        public int nr_pomi { get; set; }

        public Livada(double Suprafata, int Nr_pomi)
        {
            this.suprafata = Suprafata;
            this.nr_pomi = Nr_pomi;

        }

        public string Info()
        {
            string info = $"Suprafata livezii: {suprafata} /n Numarul de pomi din livada: {nr_pomi}";
            return info;
        }

    }
}
