using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;

namespace CentralTelefonica_EJ40
{
    public partial class FrmCentralTelefonica : Form
    {
        protected Centralita unaCentralita;
        public FrmCentralTelefonica()
        {
            InitializeComponent();
        }
        private void frmCentralTelefonica_Load(object sender, EventArgs e)
        {
             this.unaCentralita= new Centralita("Avaya");
        }

        private void btnGenerarLLamada_Click(object sender, EventArgs e)
        {
            FrmLlamador telefono = new FrmLlamador(this.unaCentralita);
            telefono.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            MostrarFacturacion();
        }
        private void MostrarFacturacion()
        {
            FrmMostrar informe = new FrmMostrar();
            informe.ShowDialog();
        }

        private void btnFacturacionLocal_Click(object sender, EventArgs e)
        {
            MostrarFacturacion();
        }

        private void btnFacturacionProvincial_Click(object sender, EventArgs e)
        {
            MostrarFacturacion();
        }
    }
}
