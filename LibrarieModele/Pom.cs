using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Pom
    {
        int[] nr_pomi;
        public string tip { get; set; }
        public int cantitate_fructe { get; set; }
        public int anul_plantarii { get; set; }
        public Pom(string Tip, int Cantitate_fructe, int Anul_plantarii)
        {
            this.tip = Tip;
            this.cantitate_fructe = Cantitate_fructe;
            this.anul_plantarii = Anul_plantarii;
        }

        public string Info()
        {
            string info = $"Tipul de pom: {tip} /n Cantitatea de fructe: {cantitate_fructe} /n Anul plantarii: {anul_plantarii}";
            return info;
        }
        public void SetNr_pomi(int[] _nr_pomi)
        {
            nr_pomi = new int[_nr_pomi.Length];
            _nr_pomi.CopyTo(nr_pomi, 0);
        }

        public int[] Nr_pomi()
        {
            return (int[])nr_pomi.Clone();
        }

    }

}
