using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Imagens
{
    public partial class FormHistograma : Form
    {
        public FormHistograma()
        {
            InitializeComponent();
        }

        private void FormHistograma_Load(object sender, EventArgs e)
        {

        }

        public void DesenhaHistograma(int[] ArrayHistograma)
        {
            Grafico.Series["Series"].Points.Clear();
            int Coluna = 0;
            for (int i = 0; i < 256; i++, Coluna++)
            {
                Grafico.Series["Series"].Points.AddXY(Coluna, ArrayHistograma[i]);
            }
        }
    }
}
