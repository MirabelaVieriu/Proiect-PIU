using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;


namespace NivelStocareDate
{
    public class GestionarePomi

    {

        Pom[] pomi = new Pom[0];
        private const int NR_MAX_POM= 50;
        private Pom[] pomi1;
        private int nrpomi;

        public GestionarePomi()
        {
           pomi1 = new Pom[NR_MAX_POM];
            nrpomi = 0;
        }

        public void Addpom(Pom pom)
        {
            pomi1[nrpomi] = pom;
            nrpomi++;
        }

        public Pom[] GetPomi(out int nrpomi)
        {
            nrpomi= this.nrpomi;
            return pomi1;
        }
   


     
    }
}
