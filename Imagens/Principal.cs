using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Imagens
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        string CaminhoImagem = "";
        int[,] VetorCinza;
        int[] ArrayHistograma = new int[256];

        private int[,] BuscarEscalaCinza()
        {
            Bitmap bm = new Bitmap(CaminhoImagem);
            int[,] VetorCinza = new int[bm.Width, bm.Height];

            for (int i = 0; i < bm.Width; i++)
            {
                for (int a = 0; a < bm.Height; a++)
                {
                    Color Cor = bm.GetPixel(i, a);
                    VetorCinza[i, a] = (int)((Cor.R * 0.3) + (Cor.G * 0.59) + (Cor.B * 0.11));
                }
            }

            return VetorCinza;
        }

        public void MontaHistograma()
        {
            //int[,] VetorCinza = BuscarEscalaCinza();
            for (int i = 0; i < 256; i++)
            {
                ArrayHistograma[i] = 0;
            }

            Bitmap bm = new Bitmap(CaminhoImagem);
            
            for (int i = 0; i < bm.Width; i++)
            {
                for (int a = 0; a < bm.Height; a++)
                {
                    int IndiceHistograma = VetorCinza[i, a];

                    ArrayHistograma[IndiceHistograma] = ArrayHistograma[IndiceHistograma] + 1;
                }
            }
        }

        private void CalculaMedia()
        {
            //int[,] VetorCinza = BuscarEscalaCinza();
            int Media = 0;
            Bitmap bm = new Bitmap(CaminhoImagem);

            for (int i = 0; i < bm.Width; i++)
            {
                for (int a = 0; a < bm.Height; a++)
                {
                    Media += VetorCinza[i, a];
                }
            }

            Media = Media / (bm.Width * bm.Height);

            txtMedia.Text = Media.ToString();
        }

        private void CalculaMediana()
        {
            //int[,] VetorCinza = BuscarEscalaCinza();
            Bitmap bm = new Bitmap(CaminhoImagem);
            List<int> Lista = new List<int>();

            for (int i = 0; i < bm.Width; i++)
            {
                for (int a = 0; a < bm.Height; a++)
                {
                    Lista.Add(VetorCinza[i, a]);
                }
            }

            Lista = Lista.OrderBy(a => a).ToList();

            int PosicaoMediana = 0;
            if ((Lista.Count % 2) == 0)
            {
                PosicaoMediana = Lista.Count / 2;
            }
            else
            {
                PosicaoMediana = (Lista.Count / 2) + 1;
            }

            txtMediana.Text = Lista[PosicaoMediana].ToString();
        }

        public void PegaModa()
        {
            //int[,] VetorCinza = BuscarEscalaCinza();
            int[] ArrayHistograma = new int[256];

            for (int i = 0; i < 256; i++)
            {
                ArrayHistograma[i] = 0;
            }

            Bitmap bm = new Bitmap(CaminhoImagem);

            for (int i = 0; i < bm.Width; i++)
            {
                for (int a = 0; a < bm.Height; a++)
                {
                    ArrayHistograma[VetorCinza[i, a]]++;
                }
            }

            int Maior = 0;
            for (int i = 0; i < 256; i++)
            {
                if (Maior < ArrayHistograma[i])
                {
                    Maior = ArrayHistograma[i];
                }
            }

            List<int> Moda = new List<int>();

            for (int i = 0; i < 256; i++)
            {
                if(Maior == ArrayHistograma[i])
                {
                    Moda.Add(i);
                }
            }
            
            txtModa.Text = "";
            Moda.ForEach(a => txtModa.Text += "," + a.ToString());
            if (txtModa.Text.Length > 0)
            {
                txtModa.Text = txtModa.Text.Substring(1);
            }
        }

        private void CalculaVariancia()
        {
            //int[,] VetorCinza = BuscarEscalaCinza();
            int Media = 0;
            int Variancia = 0;
            Bitmap bm = new Bitmap(CaminhoImagem);

            /*
            for (int i = 0; i < bm.Width; i++)
            {
                for (int a = 0; a < bm.Height; a++)
                {
                    Media += VetorCinza[i, a];
                }
            }
            Media = Media / (bm.Width * bm.Height);
            */
            
            Media = int.Parse(txtMedia.Text);

            for (int i = 0; i < bm.Width; i++)
            {
                for (int a = 0; a < bm.Height; a++)
                {
                    Variancia += (VetorCinza[i, a] - Media) ^ 2;
                }
            }
            
            txtVariancia.Text = Variancia.ToString();
        }

        private void Contagens()
        {
            //int[,] VetorCinza = BuscarEscalaCinza();
            int Menor100 = 0;
            int Maior150 = 0;
            Bitmap bm = new Bitmap(CaminhoImagem);

            for (int i = 0; i < bm.Width; i++)
            {
                for (int a = 0; a < bm.Height; a++)
                {
                    if (VetorCinza[i, a] < 100)
                    {
                        Menor100++;
                    }

                    if (VetorCinza[i, a] > 150)
                    {
                        Maior150++;
                    }
                }
            }

            txtMenor100.Text = Menor100.ToString();
            txtMaior150.Text = Maior150.ToString();
        }

        private void EstatisticaAlteracaoA()
        {
            //a)	Valores maiores ou iguais a média recebem branco.
            int Media = int.Parse(txtMedia.Text);
            
            Bitmap bm = new Bitmap(CaminhoImagem);

            int[,] VetorNovo = new int[bm.Width, bm.Height];

            for (int i = 0; i < bm.Width; i++)
            {
                for (int a = 0; a < bm.Height; a++)
                {
                    VetorNovo[i, a] = VetorCinza[i, a];

                    if (VetorCinza[i, a] >= Media)
                    {
                        VetorNovo[i, a] = 255;
                    }
                }
            }

            MostraImagemAlterada(VetorNovo);
        }

        private void EstatisticaAlteracaoB()
        {
            //b)	Valores maiores ou iguais a moda recebem 200.
            int Moda = int.Parse(txtModa.Text);

            Bitmap bm = new Bitmap(CaminhoImagem);

            int[,] VetorNovo = new int[bm.Width, bm.Height];

            for (int i = 0; i < bm.Width; i++)
            {
                for (int a = 0; a < bm.Height; a++)
                {
                    VetorNovo[i, a] = VetorCinza[i, a];

                    if (VetorCinza[i, a] >= Moda)
                    {
                        VetorNovo[i, a] = 200;
                    }
                }
            }

            MostraImagemAlterada(VetorNovo);
        }

        private void EstatisticaAlteracaoC()
        {
            //c)	Valores maiores ou iguais a mediana recebem 220.
            int Mediana = int.Parse(txtMediana.Text);

            Bitmap bm = new Bitmap(CaminhoImagem);

            int[,] VetorNovo = new int[bm.Width, bm.Height];

            for (int i = 0; i < bm.Width; i++)
            {
                for (int a = 0; a < bm.Height; a++)
                {
                    VetorNovo[i, a] = VetorCinza[i, a];

                    if (VetorCinza[i, a] >= Mediana)
                    {
                        VetorNovo[i, a] = 220;
                    }
                }
            }

            MostraImagemAlterada(VetorNovo);
        }

        private void EstatisticaAlteracaoD()
        {
            //d)	Valores menores que a média recebem 100.
            int Media = int.Parse(txtMedia.Text);

            Bitmap bm = new Bitmap(CaminhoImagem);

            int[,] VetorNovo = new int[bm.Width, bm.Height];

            for (int i = 0; i < bm.Width; i++)
            {
                for (int a = 0; a < bm.Height; a++)
                {
                    VetorNovo[i, a] = VetorCinza[i, a];

                    if (VetorCinza[i, a] < Media)
                    {
                        VetorNovo[i, a] = 100;
                    }
                }
            }

            MostraImagemAlterada(VetorNovo);
        }
        
        private void EstatisticaAlteracaoE()
        {
            //e)	Valores maiores que a média recebem 0 e menores que a média recebem 255. 
            int Media = int.Parse(txtMedia.Text);

            Bitmap bm = new Bitmap(CaminhoImagem);

            int[,] VetorNovo = new int[bm.Width, bm.Height];

            for (int i = 0; i < bm.Width; i++)
            {
                for (int a = 0; a < bm.Height; a++)
                {
                    VetorNovo[i, a] = VetorCinza[i, a];

                    if (VetorCinza[i, a] > Media)
                    {
                        VetorNovo[i, a] = 0;
                    }

                    if (VetorCinza[i, a] < Media)
                    {
                        VetorNovo[i, a] = 255;
                    }
                }
            }

            MostraImagemAlterada(VetorNovo);
        }

        private void EspelhamentoVertical()
        {
            int[,] Matriz = new int[3, 3];

            Matriz[0, 0] = -1;
            Matriz[0, 1] = 0;
            Matriz[0, 2] = 0;
            Matriz[1, 0] = 0;
            Matriz[1, 1] = 1;
            Matriz[1, 2] = 0;
            Matriz[2, 0] = 0;
            Matriz[2, 1] = 0;
            Matriz[2, 2] = 1;

            MostraImagemAlterada(ExecutaTransformacao(Matriz, new Bitmap(CaminhoImagem)));
        }

        private void EspelhamentoHorizontal()
        {
            int[,] Matriz = new int[3, 3];

            Matriz[0, 0] = 1;
            Matriz[0, 1] = 0;
            Matriz[0, 2] = 0;
            Matriz[1, 0] = 0;
            Matriz[1, 1] = -1;
            Matriz[1, 2] = 0;
            Matriz[2, 0] = 0;
            Matriz[2, 1] = 0;
            Matriz[2, 2] = 1;

            MostraImagemAlterada(ExecutaTransformacao(Matriz, new Bitmap(CaminhoImagem)));
        }

        private void EspelhamentoVerticalHorizontal()
        {
            int[,] Matriz = new int[3, 3];

            Matriz[0, 0] = -1;
            Matriz[0, 1] = 0;
            Matriz[0, 2] = 0;
            Matriz[1, 0] = 0;
            Matriz[1, 1] = 1;
            Matriz[1, 2] = 0;
            Matriz[2, 0] = 0;
            Matriz[2, 1] = 0;
            Matriz[2, 2] = 1;

            Bitmap Img = ExecutaTransformacao(Matriz, new Bitmap(CaminhoImagem));

            Matriz[0, 0] = 1;
            Matriz[0, 1] = 0;
            Matriz[0, 2] = 0;
            Matriz[1, 0] = 0;
            Matriz[1, 1] = -1;
            Matriz[1, 2] = 0;
            Matriz[2, 0] = 0;
            Matriz[2, 1] = 0;
            Matriz[2, 2] = 1;

            MostraImagemAlterada(ExecutaTransformacao(Matriz, Img));
        }

        private Bitmap ExecutaTransformacao(int[,] Matriz, Bitmap bm)
        {
            Bitmap ImagemNova = new Bitmap(bm.Width, bm.Height);

            for (int x = 0; x < bm.Width; x++)
            {
                for (int y = 0; y < bm.Height; y++)
                {
                    ImagemNova.SetPixel(x, y, Color.White);
                }
            }

            for (int x = 0; x < bm.Width; x++)
            {
                for (int y = 0; y < bm.Height; y++)
                {
                    Color Cor = bm.GetPixel(x, y);

                    int xN = (x * Matriz[0, 0]) + (y * Matriz[1, 0]) + (1 * Matriz[2, 0]);
                    int yN = (x * Matriz[0, 1]) + (y * Matriz[1, 1]) + (1 * Matriz[2, 1]);

                    if (Matriz[0, 0] == -1) xN = bm.Width + xN;
                    if (Matriz[1, 1] == -1) yN = bm.Height + yN;

                    if (xN < 0 || xN >= bm.Width || yN < 0 || yN >= bm.Height) continue;

                    ImagemNova.SetPixel(xN, yN, Cor);
                }
            }

            return ImagemNova;
        }

        private void MostraImagemAlterada(int[,] VetorAlterado)
        {
            Bitmap bm = new Bitmap(CaminhoImagem);

            Bitmap Nova = new Bitmap(bm.Width, bm.Height);

            for (int i = 0; i < bm.Width; i++)
            {
                for (int a = 0; a < bm.Height; a++)
                {
                    int TomCinza = VetorAlterado[i, a];
                    Color Cor = Color.FromArgb(TomCinza, TomCinza, TomCinza);
                    Nova.SetPixel(i, a, Cor);
                }
            }

            pbAlterada.Image = Nova;
        }

        private void MostraImagemAlterada(Bitmap ImagemAlterada)
        {
            pbAlterada.Image = ImagemAlterada;
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog imagem = new OpenFileDialog();
            //imagem.Filter = "Image files|*.jpg";
            imagem.Title = "Selecione uma imagem";

            if (imagem.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                CaminhoImagem = imagem.FileName;
                Bitmap bm = new Bitmap(CaminhoImagem);
                pbImagem.ImageLocation = CaminhoImagem;
                //pbImagem.Width = bm.Width;
                //pbImagem.Height = bm.Height;

                VetorCinza = BuscarEscalaCinza();

                MontaHistograma();
                CalculaMedia();
                CalculaMediana();
                PegaModa();
                CalculaVariancia();
                Contagens();

                toolEfeitos.Enabled = true;
                btHistograma.Enabled = true;
            }
        }

        private void aValoresMaioresOuIguaisAMédiaRecebemBrancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstatisticaAlteracaoA();
        }

        private void bValoresMaioresOuIguaisAModaRecebem200ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstatisticaAlteracaoB();
        }

        private void cValoresMaioresOuIguaisAMedianaRecebem220ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstatisticaAlteracaoC();
        }

        private void dValoresMenoresQueAMédiaRecebem100ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstatisticaAlteracaoD();
        }

        private void eValoresMaioresQueAMédiaRecebem0EMenoresQueAMédiaRecebem255ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstatisticaAlteracaoE();
        }

        private void btHistograma_Click(object sender, EventArgs e)
        {
            FormHistograma FormHist = new FormHistograma();
            FormHist.DesenhaHistograma(ArrayHistograma);
            FormHist.Show();
        }

        private void espelhamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EspelhamentoVertical();
        }

        private void rotacionar180ºToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EspelhamentoHorizontal();
        }

        private void espelhamentoVerticalEHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EspelhamentoVerticalHorizontal();
        }
    }
}
