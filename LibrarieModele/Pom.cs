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
                tip,
                cantitate_fructe,
                anul_plantarii);

            return obiectPomPentruFisier;
        }

        public string InfoPom()
        {
            string info = $"Tipul de pom: {tip} \n Cantitatea de fructe: {cantitate_fructe} \n Anul plantarii: {anul_plantarii}";
            return info;
        }

      
    
        

    }

}
