using System;
using System.Collections.Generic;
using System.Text;

namespace Loto
{
    class ListaAposta
    {
        private List<ApostaTime40> listaApostaTime40 = new List<ApostaTime40>();

        internal List<ApostaTime40> ListaApostaTime40
        {
            get { return listaApostaTime40; }
        }

        public void add(ApostaTime40 sorteio)
        {
            listaApostaTime40.Add(sorteio);
        }

        public void remove(ApostaTime40 sorteio)
        {
            listaApostaTime40.Remove(sorteio);
        }

        public ApostaTime40 getJogo(int posicao)
        {
            return listaApostaTime40[posicao];
        }
    }
}
