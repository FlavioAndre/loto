using System;
using System.Collections.Generic;
using System.Text;

namespace Loto
{
    class ListaConferenciaLotofacil
    {
        private List<ConferenciaLotofacil> listaConferenciaLotofacil = new List<ConferenciaLotofacil>();

        internal List<ConferenciaLotofacil> ListaConferenciaLotofacils
        {
            get { return listaConferenciaLotofacil; }
        }

        public void add(ConferenciaLotofacil sorteio)
        {
            listaConferenciaLotofacil.Add(sorteio);
        }

        public void remove(ConferenciaLotofacil sorteio)
        {
            listaConferenciaLotofacil.Remove(sorteio);
        }

        public ConferenciaLotofacil getJogo(int posicao)
        {
            return listaConferenciaLotofacil[posicao];
        }
    }
}
