using System;
using System.Collections.Generic;
using System.Text;

namespace Loto
{
    class ApostaLotofacil
    {
        private int concurso;
        public int Concurso
        {
            get { return concurso; }
            set { concurso = value; }
        }

        private int[] apostas = new int[80];

        public int[] Apostas
        {
            get { return apostas; }
            set { apostas = value; }
        }

        
    }
}
