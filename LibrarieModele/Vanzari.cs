using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Vanzari
    {
        private const int TIP_FRUCTE = 0;
        private const int CANTITATEE = 1;
        private const int PRET= 2;
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        public int tip_fructe { get; set; }
        public double cantitate { get; set; }
        public float pret { get; set; }

        public Vanzari(int Tip_fructe, double Cantitate, float Pret)
        {
            this.tip_fructe = Tip_fructe;
            this.cantitate = Cantitate;
            this.pret = Pret;

        }
        public Vanzari(string linieFisier)
        {
            string[] dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            this.tip_fructe = int.Parse(dateFisier[TIP_FRUCTE]);
            this.cantitate = double.Parse(dateFisier[CANTITATEE]);
            this.pret = float.Parse(dateFisier[PRET]);
        }


        public string Info()
        {
            string info = $"Tipul de fructe: {tip_fructe} /n Cantitatea de fructe: {cantitate} /n Pretul pe kg :{pret}";
            return info;
        }

    }
}
