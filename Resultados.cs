using System;
using System.Collections.Generic;
using System.Text;

namespace Loto
{
    class Resultados
    {
        private List<Sorteio> listaSorteio = new List<Sorteio>();

        internal List<Sorteio> ListaSorteio
        {
            get { return listaSorteio; }
        }

        public void add(Sorteio sorteio)
        {
            listaSorteio.Add(sorteio);
        }

        public void remove(Sorteio sorteio)
        {
            listaSorteio.Remove(sorteio);
        }

        public Sorteio getJogo(int posicao)
        {
            return listaSorteio[posicao];
        }
    }
}
