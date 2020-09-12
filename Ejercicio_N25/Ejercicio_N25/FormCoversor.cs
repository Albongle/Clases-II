using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conversor;

namespace Ejercicio_N25
{
    public partial class FormConversor : Form
    {
        public FormConversor()
        {
            InitializeComponent();
        }

        private void btnBinarioDecimal_Click(object sender, EventArgs e)
        {
            NumeroBinario numBinario;
            numBinario = this.txtBinario.Text;
            this.txtBinarioDecimal.Text = ((NumeroDecimal)numBinario).GetNumero().ToString();
        }

        private void btnDecimalBinario_Click(object sender, EventArgs e)
        {
            double numAux;
            NumeroDecimal numDecimal;
            if(double.TryParse(this.txtDecimal.Text, out numAux))
            {
                numDecimal = numAux;
            }
            else
            {
                numDecimal = 0;
            }
            this.txtDecimalBinario.Text = ((NumeroBinario)numDecimal).GetNumero();
        }

        private void txtDecimal_KeyPress(object sender, KeyPressEventArgs e)
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
                txtDecimal.Focus();
                MessageBox.Show("Solo numeros (Positivos)","Alerta" ,MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void txtBinario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && e.KeyChar.ToString().Equals("1") || e.KeyChar.ToString().Equals("0"))
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
                MessageBox.Show("Solo Digitos Binarios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtBinario.Focus();
            }
        }
    }
}
