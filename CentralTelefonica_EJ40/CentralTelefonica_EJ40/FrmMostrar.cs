using CentralitaHerencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentralTelefonica_EJ40
{
    public partial class FrmMostrar : Form
    {
        public FrmMostrar(Centralita c)
        {
            InitializeComponent();
            this.rchTextInforme.Text = c.ToString();
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {

        }
    }
}
