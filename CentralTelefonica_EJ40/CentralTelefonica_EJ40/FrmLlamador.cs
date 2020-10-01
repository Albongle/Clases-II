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
    public partial class FrmLlamador : Form
    {
        protected Centralita centralita;
        public FrmLlamador(Centralita centralita)
        {
            InitializeComponent();
            this.centralita = centralita;
        }
        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            this.cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
        }
        public Centralita Llamador
        {
            get
            {
                return this.centralita;
            }
        }

        private void txtNroDestino_TextChanged(object sender, EventArgs e)
        {
            if(this.txtNroDestino.Text.IndexOf('#')==0)
            {
                this.cmbFranja.Enabled = true;
                
            }
            else
            {
                this.cmbFranja.Enabled = false;
            }
        }

        private void btnNumeral_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btnNumeral.Text);
        }

        private void btnNumero1_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btnNumero1.Text);
        }

        private void btnNumero2_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btnNumero2.Text);
        }

        private void btnNumero3_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btnNumero3.Text);
        }

        private void btnNumero4_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btnNumero4.Text);
        }

        private void btnNumero5_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btnNumero5.Text);
        }

        private void btnNumero6_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btnNumero6.Text);
        }

        private void btnNumero7_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btnNumero7.Text);
        }

        private void btnNumero8_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btnNumero8.Text);
        }

        private void btnNumero9_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btnNumero9.Text);
        }

        private void btnAsterisco_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btnAsterisco.Text);
        }

        private void btnNumero0_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btnNumero0.Text);
        }
        private void CargarNumero(string digitoPresionado)
        {
            if (this.txtNroDestino.Text == "Nro Destino")
            {
                this.txtNroDestino.Text = string.Empty;
            }
    
               this.txtNroDestino.Text += digitoPresionado;
            
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text="Nro Destino";
            this.txtNroOrigen.Text = "Nro Origen";
        }
        private void txtNroOrigen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
