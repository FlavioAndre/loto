using System;
using System.Collections.Generic;
using System.Text;

namespace Loto
{
    class Sorteio
    {
        private int concurso;

        public int Concurso
        {
            get { return concurso; }
            set { concurso = value; }
        }
        private DateTime data;

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }
        private Jogo jogo = new Jogo();

        internal Jogo Jogo
        {
            get { return jogo; }
            set { jogo = value; }
        }
        private int ganhadores15;

        public int Ganhadores15
        {
            get { return ganhadores15; }
            set { ganhadores15 = value; }
        }
        private int ganhadores14;

        public int Ganhadores14
        {
            get { return ganhadores14; }
            set { ganhadores14 = value; }
        }
        private int ganhadores13;

        public int Ganhadores13
        {
            get { return ganhadores13; }
            set { ganhadores13 = value; }
        }
        private int ganhadores12;

        public int Ganhadores12
        {
            get { return ganhadores12; }
            set { ganhadores12 = value; }
        }
        private int ganhadores11;

        public int Ganhadores11
        {
            get { return ganhadores11; }
            set { ganhadores11 = value; }
        }
        private decimal valorRateio15;

        public decimal ValorRateio15
        {
            get { return valorRateio15; }
            set { valorRateio15 = value; }
        }
        private decimal valorRateio14;

        public decimal ValorRateio14
        {
            get { return valorRateio14; }
            set { valorRateio14 = value; }
        }
        private decimal valorRateio13;

        public decimal ValorRateio13
        {
            get { return valorRateio13; }
            set { valorRateio13 = value; }
        }
        private decimal valorRateio12;

        public decimal ValorRateio12
        {
            get { return valorRateio12; }
            set { valorRateio12 = value; }
        }
        private decimal valorRateio11;

        public decimal ValorRateio11
        {
            get { return valorRateio11; }
            set { valorRateio11 = value; }
        }
    }
}
