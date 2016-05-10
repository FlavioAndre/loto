using System;
using System.Collections.Generic;
using System.Text;

namespace Loto
{
    class ListaApostaLotofacil
    {
        private List<ApostaLotofacil> listaApostaLotofacil = new List<ApostaLotofacil>();

        internal List<ApostaLotofacil> ListaApostaLotofaceis
        {
            get { return listaApostaLotofacil; }
        }

        public void add(ApostaLotofacil sorteio)
        {
            listaApostaLotofacil.Add(sorteio);
        }

        public void remove(ApostaLotofacil sorteio)
        {
            listaApostaLotofacil.Remove(sorteio);
        }

        public ApostaLotofacil getJogo(int posicao)
        {
            return listaApostaLotofacil[posicao];
        }
    }
}
