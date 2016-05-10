using System;
using System.Collections.Generic;
using System.Text;

namespace Loto
{
    class SorteioTime
    {
        private int concurso;
        public int Concurso
        {
            get { return concurso; }
            set { concurso = value; }
        }

        private JogoTime jogo = new JogoTime();
        internal JogoTime Jogo
        {
            get { return jogo; }
            set { jogo = value; }
        }

        public int Bola1
        {
            get { return this.Jogo.Numero1; }
        }

        public int Bola2
        {
            get { return this.Jogo.Numero2; }
        }

        public int Bola3
        {
            get { return this.Jogo.Numero3; }
        }

        public int Bola4
        {
            get { return this.Jogo.Numero4; }
        }

        public int Bola5
        {
            get { return this.Jogo.Numero5; }
        }

        public int Bola6
        {
            get { return this.Jogo.Numero6; }
        }

        public int Bola7
        {
            get { return this.Jogo.Numero7; }
        }
    }
}
