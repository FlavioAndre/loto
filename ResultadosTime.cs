using System;
using System.Collections.Generic;
using System.Text;

namespace Loto
{
    class ResultadosTime
    {
        private List<SorteioTime> listaSorteioTime = new List<SorteioTime>();

        internal List<SorteioTime> ListaSorteioTime
        {
            get { return listaSorteioTime; }
        }

        public void add(SorteioTime sorteio)
        {
            listaSorteioTime.Add(sorteio);
        }

        public void remove(SorteioTime sorteio)
        {
            listaSorteioTime.Remove(sorteio);
        }

        public SorteioTime getJogo(int posicao)
        {
            return listaSorteioTime[posicao];
        }
    }
}
