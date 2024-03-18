using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Vanzari
    {
        public int tip_fructe { get; set; }
        public double cantitate { get; set; }
        public float pret { get; set; }

        public Vanzari(int Tip_fructe, double Cantitate, float Pret)
        {
            this.tip_fructe = Tip_fructe;
            this.cantitate = Cantitate;
            this.pret = Pret;

        }

        public string Info()
        {
            string info = $"Tipul de fructe: {tip_fructe} /n Cantitatea de fructe: {cantitate} /n Pretul pe kg :{pret}";
            return info;
        }

    }
}
