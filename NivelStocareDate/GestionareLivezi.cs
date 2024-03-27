using LibrarieModele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NivelStocareDate
{
    public class GestionareLivezi
    {

        Livada[] livada = new Livada[0];
        private const int NR_MAX_LIVEZI = 30;
        private Livada[] livada1;
        private int nrlivezi;

        public GestionareLivezi()
        {
            livada1 = new Livada[NR_MAX_LIVEZI];
            nrlivezi = 0;
        }

        public void Addlivada(Livada livada)
        {
            livada1[nrlivezi] = livada;
            nrlivezi++;
        }

        public Livada[] GetLivada(out int nrlivezi)
        {
            nrlivezi = this.nrlivezi;
            return livada1;
        }
    }
}
