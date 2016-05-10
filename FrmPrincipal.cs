using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Loto
{
    public partial class frmPrincipal : Form
    {
        private ListaAposta resultados = new ListaAposta();
        private ListaApostaLotofacil listaResultadosLotofacil = new ListaApostaLotofacil();

        private ResultadosTime resultadosTime = new ResultadosTime();
        private Resultados resultadosLotofacil = new Resultados();

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregarLotofacil();
           
        }

        private void CarregarTimemania()
        {

            if (this.openFileDialogLoto.ShowDialog() == DialogResult.OK)
            {
                string Pfad = this.openFileDialogLoto.FileName;

                string[] consulta = File.ReadAllLines(Pfad, System.Text.Encoding.UTF7);

                int contaJogos = 0;
                foreach (string item in consulta)
                {
                    string[] numeros = item.Split('	');
                    JogoTime jogo = new JogoTime();
                    SorteioTime sorteio = new SorteioTime();
                    contaJogos++;
                    for (int i = 1; i <= numeros.Length; i++)
                    {
                        switch (i)
                        {
                            case 1: // concurso
                                sorteio.Concurso = contaJogos;
                                jogo.Numero1 = Convert.ToInt32(numeros[i - 1]);
                                break;
                            case 2:
                                jogo.Numero2 = Convert.ToInt32(numeros[i - 1]);
                                break;
                            case 3:
                                jogo.Numero3 = Convert.ToInt32(numeros[i - 1]);
                                break;
                            case 4:
                                jogo.Numero4 = Convert.ToInt32(numeros[i - 1]);
                                break;
                            case 5:
                                jogo.Numero5 = Convert.ToInt32(numeros[i - 1]);
                                break;
                            case 6:
                                jogo.Numero6 = Convert.ToInt32(numeros[i - 1]);
                                break;
                            case 7:
                                jogo.Numero7 = Convert.ToInt32(numeros[i - 1]);
                                break;
                        }
                    }
                    sorteio.Jogo = jogo;
                    resultadosTime.add(sorteio);
                }
                dataGridView1.DataSource = resultadosTime.ListaSorteioTime;
            }
        }

        private void CarregarLotofacil()
        {
            if (this.openFileDialogLoto.ShowDialog() == DialogResult.OK)
            {
                string Pfad = this.openFileDialogLoto.FileName;

                string[] consulta = File.ReadAllLines(Pfad, System.Text.Encoding.UTF7);
                

                foreach (string item in consulta)
                {
                    string[] numeros = item.Split('	');
                    //string[] numeros = item.Split(' ');
                    Jogo jogo = new Jogo();
                    Sorteio sorteio = new Sorteio();
                    sorteio.Concurso ++;
                    sorteio.Data = DateTime.Now;
                    for (int i = 1; i <= numeros.Length; i++)
                    {
                        switch (i)
                        {
                            case 1:
                                jogo.Numero1 = Convert.ToInt32(numeros[i - 1]);
                                break;
                            case 2:
                                jogo.Numero2 = Convert.ToInt32(numeros[i - 1]);
                                break;
                            case 3:
                                jogo.Numero3 = Convert.ToInt32(numeros[i - 1]);
                                break;
                            case 4:
                                jogo.Numero4 = Convert.ToInt32(numeros[i - 1]);
                                break;
                            case 5:
                                jogo.Numero5 = Convert.ToInt32(numeros[i - 1]);
                                break;
                            case 6:
                                jogo.Numero6 = Convert.ToInt32(numeros[i - 1]);
                                break;
                            case 7:
                                jogo.Numero7 = Convert.ToInt32(numeros[i - 1]);
                                break;
                            case 8:
                                jogo.Numero8 = Convert.ToInt32(numeros[i - 1]);
                                break;
                            case 9:
                                jogo.Numero9 = Convert.ToInt32(numeros[i - 1]);
                                break;
                            case 10:
                                jogo.Numero10 = Convert.ToInt32(numeros[i - 1]);
                                break;
                            case 11:
                                jogo.Numero11 = Convert.ToInt32(numeros[i - 1]);
                                break;
                            case 12:
                                jogo.Numero12 = Convert.ToInt32(numeros[i - 1]);
                                break;
                            case 13:
                                jogo.Numero13 = Convert.ToInt32(numeros[i - 1]);
                                break;
                            case 14:
                                jogo.Numero14 = Convert.ToInt32(numeros[i - 1]);
                                break;
                            case 15:
                                jogo.Numero15 = Convert.ToInt32(numeros[i - 1]);
                                break;
                        }
                    }
                    sorteio.Jogo = jogo;
                    resultadosLotofacil.add(sorteio);
                }
                dataGridView1.DataSource = resultadosLotofacil.ListaSorteio;
            }
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            CarregarApostaLotofacil();
        }

        private void CarregarApostaLotofacil()
        {
            if (this.openFileDialogLoto.ShowDialog() == DialogResult.OK)
            {
                string Pfad = this.openFileDialogLoto.FileName;

                string[] consulta = File.ReadAllLines(Pfad, System.Text.Encoding.UTF7);

                int contaJogos = 0;
                foreach (string item in consulta)
                {
                    //string[] numeros = item.Split('	');
                    string[] numeros = item.Split(' ');
                    ApostaLotofacil jogo = new ApostaLotofacil();
                    contaJogos++;
                    jogo.Concurso = contaJogos;
                    for (int i = 0; i < numeros.Length; i++)
                    {
                        jogo.Apostas[i] = Convert.ToInt32(numeros[i]);
                    }
                    listaResultadosLotofacil.add(jogo);
                }
                dataGridView2.DataSource = listaResultadosLotofacil.ListaApostaLotofaceis;
            }
        }

        private void CarregarTimeMania()
        {
            if (this.openFileDialogLoto.ShowDialog() == DialogResult.OK)
            {
                string Pfad = this.openFileDialogLoto.FileName;

                string[] consulta = File.ReadAllLines(Pfad, System.Text.Encoding.UTF7);

                int contaJogos = 0;
                foreach (string item in consulta)
                {
                    string[] numeros = item.Split(' ');
                    ApostaTime40 jogo = new ApostaTime40();
                    contaJogos++;
                    jogo.Concurso = contaJogos;
                    for (int i = 0; i < numeros.Length; i++)
                    {
                        jogo.Apostas[i] = Convert.ToInt32(numeros[i]);
                    }
                    resultados.add(jogo);
                }
                dataGridView2.DataSource = resultados.ListaApostaTime40;
            }
        }

        private void btnConferir_Click(object sender, EventArgs e)
        {
            ConferirLotofacil();
        }

        private void ConferirLotofacil2()
        {
            ListaConferenciaLotofacil lista = new ListaConferenciaLotofacil();
            int linhaMaior11 = 0;
            int linhaMaior5 = 0;
            int linhaMaior12 = 0;
            int linhaMaior13 = 0;
            int linhaMaior14 = 0;

            int Acerto5 = 0;
            int Acerto11 = 0;
            int Acerto12 = 0;
            int Acerto13 = 0;
            int Acerto14 = 0;

            int concursoMaior11 = 0;
            int concursoMaior5 = 0;
            int concursoMaior12 = 0;
            int concursoMaior13 = 0;
            int concursoMaior14 = 0;

            //foreach (ApostaLotofacil aposta in listaResultadosLotofacil.ListaApostaLotofaceis)
            int tamApostas = listaResultadosLotofacil.ListaApostaLotofaceis.Count;
            for(int a=0; a<tamApostas;a++)
            {
                //ConferenciaLotofacil confere = new ConferenciaLotofacil();
                //foreach (ApostaLotofacil sorteio in listaResultadosLotofacil.ListaApostaLotofaceis)
                Acerto11 = 0;
                Acerto12 = 0;
                Acerto13 = 0;
                Acerto14 = 0;
                for(int b = 0; b<tamApostas;b++)
                {
                    int acerto = 0;
                    //foreach (long numero in aposta.Apostas)

                    for(int y=0;y< 15; y++)
                    {
                        if (listaResultadosLotofacil.ListaApostaLotofaceis[a].Apostas[y] == listaResultadosLotofacil.ListaApostaLotofaceis[b].Apostas[0] ||
                           listaResultadosLotofacil.ListaApostaLotofaceis[a].Apostas[y] == listaResultadosLotofacil.ListaApostaLotofaceis[b].Apostas[1] ||
                           listaResultadosLotofacil.ListaApostaLotofaceis[a].Apostas[y] == listaResultadosLotofacil.ListaApostaLotofaceis[b].Apostas[2] ||
                           listaResultadosLotofacil.ListaApostaLotofaceis[a].Apostas[y] == listaResultadosLotofacil.ListaApostaLotofaceis[b].Apostas[3] ||
                           listaResultadosLotofacil.ListaApostaLotofaceis[a].Apostas[y] == listaResultadosLotofacil.ListaApostaLotofaceis[b].Apostas[4] ||
                           listaResultadosLotofacil.ListaApostaLotofaceis[a].Apostas[y] == listaResultadosLotofacil.ListaApostaLotofaceis[b].Apostas[5] ||
                           listaResultadosLotofacil.ListaApostaLotofaceis[a].Apostas[y] == listaResultadosLotofacil.ListaApostaLotofaceis[b].Apostas[6] ||
                           listaResultadosLotofacil.ListaApostaLotofaceis[a].Apostas[y] == listaResultadosLotofacil.ListaApostaLotofaceis[b].Apostas[7] ||
                           listaResultadosLotofacil.ListaApostaLotofaceis[a].Apostas[y] == listaResultadosLotofacil.ListaApostaLotofaceis[b].Apostas[8] ||
                           listaResultadosLotofacil.ListaApostaLotofaceis[a].Apostas[y] == listaResultadosLotofacil.ListaApostaLotofaceis[b].Apostas[9] ||
                           listaResultadosLotofacil.ListaApostaLotofaceis[a].Apostas[y] == listaResultadosLotofacil.ListaApostaLotofaceis[b].Apostas[10] ||
                           listaResultadosLotofacil.ListaApostaLotofaceis[a].Apostas[y] == listaResultadosLotofacil.ListaApostaLotofaceis[b].Apostas[11] ||
                           listaResultadosLotofacil.ListaApostaLotofaceis[a].Apostas[y] == listaResultadosLotofacil.ListaApostaLotofaceis[b].Apostas[12] ||
                           listaResultadosLotofacil.ListaApostaLotofaceis[a].Apostas[y] == listaResultadosLotofacil.ListaApostaLotofaceis[b].Apostas[13] ||
                           listaResultadosLotofacil.ListaApostaLotofaceis[a].Apostas[y] == listaResultadosLotofacil.ListaApostaLotofaceis[b].Apostas[14])
                        {
                            acerto++;
                        }
                       
                    }
                    switch (acerto)
                    {
                        case 11:
                            Acerto11++;
                            break;
                        case 12:
                            Acerto12++;
                            break;
                        case 13:
                            Acerto13++;
                            break;
                        case 14:
                            Acerto14++;
                            break;
                    }

                }
                
                if (Acerto11 > linhaMaior11)
                {
                    linhaMaior11 = Acerto11;
                    concursoMaior11 = a;
                    this.lbl11pontos.Text = String.Format("Linha Maior 11: {0} Linha: {1}", linhaMaior11, concursoMaior11);
                }
                if (Acerto12 > linhaMaior12)
                {
                    linhaMaior12 = Acerto12;
                    concursoMaior12 = a;
                    this.lbl12pontos.Text = String.Format("Linha Maior 12: {0} Linha: {1}", linhaMaior12, concursoMaior12);
                }
                if (Acerto13 > linhaMaior13)
                {
                    linhaMaior13 = Acerto13;
                    concursoMaior13 = a;
                    this.lbl13pontos.Text = String.Format("Linha Maior 13: {0} Linha: {1}", linhaMaior13, concursoMaior13);
                }
                if (Acerto14 > linhaMaior14)
                {
                    linhaMaior14 = Acerto14;
                    concursoMaior14 = a;
                    this.lbl14pontos.Text = String.Format("Linha Maior 14: {0} Linha: {1}", linhaMaior14, concursoMaior14);
                }
                Application.DoEvents();
                //lista.add(confere);

            }
//            dataGridView3.DataSource = lista.ListaConferenciaLotofacils;
            this.lbl11pontos.Text = String.Format("Linha Maior 11: {0} Linha: {1}", linhaMaior11, concursoMaior11);
            this.lbl12pontos.Text = String.Format("Linha Maior 12: {0} Linha: {1}", linhaMaior12, concursoMaior12);
            this.lbl13pontos.Text = String.Format("Linha Maior 13: {0} Linha: {1}", linhaMaior13, concursoMaior13);
            this.lbl14pontos.Text = String.Format("Linha Maior 14: {0} Linha: {1}", linhaMaior14, concursoMaior14);

        }

        private void ConferirLotofacil()
        {
            ListaConferenciaLotofacil lista = new ListaConferenciaLotofacil();
            int linhaMaior3 = 0;
            int linhaMaior4 = 0;
            int linhaMaior5 = 0;
            int linhaMaior11 = 0;
            int linhaMaior12 = 0;
            int linhaMaior13 = 0;
            int linhaMaior14 = 0;
            int linhaMaior15 = 0;

            int concursoMaior3 = 0;
            int concursoMaior4 = 0;
            int concursoMaior5 = 0;
            int concursoMaior11 = 0;
            int concursoMaior12 = 0;
            int concursoMaior13 = 0;
            int concursoMaior14 = 0;
            int concursoMaior15 = 0;

            foreach (ApostaLotofacil aposta in listaResultadosLotofacil.ListaApostaLotofaceis)
            {
                ConferenciaLotofacil confere = new ConferenciaLotofacil();
                foreach (Sorteio sorteio in resultadosLotofacil.ListaSorteio)
                {
                    long acerto = 0;
                    foreach (long numero in aposta.Apostas)
                    {
                        if (numero > 0)
                        {
                            if (numero == sorteio.Jogo.Numero1 ||
                               numero == sorteio.Jogo.Numero2 ||
                               numero == sorteio.Jogo.Numero3 ||
                               numero == sorteio.Jogo.Numero4 ||
                               numero == sorteio.Jogo.Numero5 ||
                               numero == sorteio.Jogo.Numero6 ||
                               numero == sorteio.Jogo.Numero7 ||
                               numero == sorteio.Jogo.Numero8 ||
                               numero == sorteio.Jogo.Numero9 ||
                               numero == sorteio.Jogo.Numero10 ||
                               numero == sorteio.Jogo.Numero11 ||
                               numero == sorteio.Jogo.Numero12 ||
                               numero == sorteio.Jogo.Numero13 ||
                               numero == sorteio.Jogo.Numero14 ||
                               numero == sorteio.Jogo.Numero15)
                            {
                                acerto++;
                            }
                        }
                    }
                    switch (acerto)
                    {
                        case 3:
                            confere.Acerto3++;
                            break;
                        case 4:
                            confere.Acerto4++;
                            break;
                        case 5:
                            confere.Acerto5++;
                            break;
                       /* case 11:
                            confere.Acerto11++;
                            break;
                        case 12:
                            confere.Acerto12++;
                            break;
                        case 13:
                            confere.Acerto13++;
                            break;
                        case 14:
                            confere.Acerto14++;
                            break;
                        case 15:
                            confere.Acerto15++;
                            break;*/
                    }

                }
                confere.Concurso = aposta.Concurso;

                if (confere.Acerto3 > linhaMaior3)
                {
                    linhaMaior3 = confere.Acerto3;
                    concursoMaior3 = confere.Concurso;
                    this.lbl3pontos.Text = String.Format("Linha Maior 3: {0} Linha: {1}", linhaMaior3, concursoMaior3);
                    Application.DoEvents();
                }

                if (confere.Acerto4 > linhaMaior4)
                {
                    linhaMaior4 = confere.Acerto4;
                    concursoMaior4 = confere.Concurso;
                    this.lbl4pontos.Text = String.Format("Linha Maior 4: {0} Linha: {1}", linhaMaior4, concursoMaior4);
                    Application.DoEvents();
                }

                if (confere.Acerto5 > linhaMaior5)
                {
                    linhaMaior5 = confere.Acerto5;
                    concursoMaior5 = confere.Concurso;
                    this.lbl5pontos.Text = String.Format("Linha Maior 5: {0} Linha: {1}", linhaMaior5, concursoMaior5);
                    Application.DoEvents();
                }

              /*  if (confere.Acerto11 > linhaMaior11)
                {
                    linhaMaior11 = confere.Acerto11;
                    concursoMaior11 = confere.Concurso;
                    this.lbl11pontos.Text = String.Format("Linha Maior 11: {0} Linha: {1}", linhaMaior11, concursoMaior11);
                    Application.DoEvents();
                }
                if (confere.Acerto12 > linhaMaior12)
                {
                    linhaMaior12 = confere.Acerto12;
                    concursoMaior12 = confere.Concurso;
                    this.lbl12pontos.Text = String.Format("Linha Maior 12: {0} Linha: {1}", linhaMaior12, concursoMaior12);
                    Application.DoEvents();
                }
                if (confere.Acerto13 > linhaMaior13)
                {
                    linhaMaior13 = confere.Acerto13;
                    concursoMaior13 = confere.Concurso;
                    this.lbl13pontos.Text = String.Format("Linha Maior 13: {0} Linha: {1}", linhaMaior13, concursoMaior13);
                    Application.DoEvents();
                }
                if (confere.Acerto14 > linhaMaior14)
                {
                    linhaMaior14 = confere.Acerto14;
                    concursoMaior14 = confere.Concurso;
                    this.lbl14pontos.Text = String.Format("Linha Maior 14: {0} Linha: {1}", linhaMaior14, concursoMaior14);
                    Application.DoEvents();
                }

                if (confere.Acerto15 > linhaMaior15)
                {
                    linhaMaior15 = confere.Acerto15;
                    concursoMaior15 = confere.Concurso;
                    this.lbl15pontos.Text = String.Format("Linha Maior 15: {0} Linha: {1}", linhaMaior15, concursoMaior15);
                    Application.DoEvents();
                }

                lista.add(confere);*/

            }
          /*  dataGridView3.DataSource = lista.ListaConferenciaLotofacils;
            this.lbl11pontos.Text = String.Format("Linha Maior 11: {0} Linha: {1}", linhaMaior11,concursoMaior11);
            this.lbl12pontos.Text = String.Format("Linha Maior 12: {0} Linha: {1}", linhaMaior12, concursoMaior12);
            this.lbl13pontos.Text = String.Format("Linha Maior 13: {0} Linha: {1}", linhaMaior13, concursoMaior13);
            this.lbl14pontos.Text = String.Format("Linha Maior 14: {0} Linha: {1}", linhaMaior14, concursoMaior14);
            */
        }

        private void ConferirTimemania()
        {
            ListaConferenciaTime lista = new ListaConferenciaTime();

            foreach (ApostaTime40 aposta in resultados.ListaApostaTime40)
            {
                ConferenciaTime confere = new ConferenciaTime();
                foreach (SorteioTime sorteio in resultadosTime.ListaSorteioTime)
                {
                    int acerto = 0;
                    foreach (int numero in aposta.Apostas)
                    {
                        if (numero == sorteio.Bola1 ||
                           numero == sorteio.Bola2 ||
                           numero == sorteio.Bola3 ||
                           numero == sorteio.Bola4 ||
                           numero == sorteio.Bola5 ||
                           numero == sorteio.Bola6 ||
                           numero == sorteio.Bola7)
                        {
                            acerto++;
                        }
                    }
                    switch (acerto)
                    {
                        case 3:
                            confere.Acerto3++;
                            break;
                        case 4:
                            confere.Acerto4++;
                            break;
                        case 5:
                            confere.Acerto5++;
                            break;
                        case 6:
                            confere.Acerto6++;
                            break;
                        case 7:
                            confere.Acerto7++;
                            break;
                    }

                }
                confere.Concurso = aposta.Concurso;
                lista.add(confere);

            }
            dataGridView3.DataSource = lista.ListaConferenciaTimes;

        }


    }
}
