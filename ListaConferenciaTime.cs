using System;
using System.Collections.Generic;
using System.Text;

namespace Loto
{
    class ListaConferenciaTime
    {
        private List<ConferenciaTime> listaConferenciaTime = new List<ConferenciaTime>();

        internal List<ConferenciaTime> ListaConferenciaTimes
        {
            get { return listaConferenciaTime; }
        }

        public void add(ConferenciaTime sorteio)
        {
            listaConferenciaTime.Add(sorteio);
        }

        public void remove(ConferenciaTime sorteio)
        {
            listaConferenciaTime.Remove(sorteio);
        }

        public ConferenciaTime getJogo(int posicao)
        {
            return listaConferenciaTime[posicao];
        }
    }
}
