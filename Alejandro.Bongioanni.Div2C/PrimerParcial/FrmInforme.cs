using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcial
{
    public partial class FrmInforme : Form
    {
        public FrmInforme(Bar nuevoBar)
        {
            InitializeComponent();
            this.rtbSalidaDeTest.Text = nuevoBar.ToString();
        }

        private void FrmInforme_Load(object sender, EventArgs e)
        {
        }
    }
}
