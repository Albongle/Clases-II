using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Temperatura;

namespace Ejercicio_N24
{
    public partial class FormTemperartura : Form
    {
        public FormTemperartura()
        {
            InitializeComponent();
        }
        private void btnFahrenheit_Click(object sender, EventArgs e)
        {
            double numAux;
            Fahrenheit temp;
            if(double.TryParse(this.txtFahrenheit.Text, out numAux))
            {
                temp = numAux;
            }
            else
            {
                temp = 0;
            }
            this.txtFahFah.Text = temp.GetTemperatura().ToString("0.00");
            this.txtFahCelcius.Text = ((Celsius)temp).GetTemperatura().ToString("0.00");
            this.txtFahKelvin.Text= ((Kelvin)temp).GetTemperatura().ToString("0.00");
        }
        private void btnCelcius_Click(object sender, EventArgs e)
        {
            double numAux;
            Celsius temp;
            if (double.TryParse(this.txtCelcius.Text, out numAux))
            {
                temp = numAux;
            }
            else
            {
                temp = 0;
            }
            this.txtCelCel.Text = temp.GetTemperatura().ToString("0.00");
            this.txtCelciusFah.Text= ((Fahrenheit)temp).GetTemperatura().ToString("0.00");
            this.txtCelKelvin.Text= ((Kelvin)temp).GetTemperatura().ToString("0.00");
        }
        private void btnKelvin_Click(object sender, EventArgs e)
        {
            double numAux;
            Kelvin temp;
            if (double.TryParse(this.txtKelvin.Text, out numAux))
            {
                temp = numAux;
            }
            else
            {
                temp = 0;
            }
            this.txtKelKel.Text= temp.GetTemperatura().ToString("0.00");
            this.txtKelvinCel.Text= ((Celsius)temp).GetTemperatura().ToString("0.00");
            this.txtKelvinFah.Text= ((Kelvin)temp).GetTemperatura().ToString("0.00");
        }

        private void txtFahrenheit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar.ToString().Equals(",") && !(this.txtFahrenheit.Text.Contains(",")))
            {
                e.Handled = false;
            }
            else if (e.KeyChar.ToString().Equals("-") && this.txtFahrenheit.Text.Length == 0)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo numeros (Positivos/Negativos) o numeros con coma", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtCelcius_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar.ToString().Equals(",") && !(this.txtCelcius.Text.Contains(",")))
            {
                e.Handled = false;
            }
            else if (e.KeyChar.ToString().Equals("-") && this.txtCelcius.Text.Length == 0)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo numeros (Positivos/Negativos) o numeros con coma", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtKelvin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar.ToString().Equals(",") && !(this.txtKelvin.Text.Contains(",")))
            {
                e.Handled = false;
            }
            else if (e.KeyChar.ToString().Equals("-") && this.txtKelvin.Text.Length == 0)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo numeros (Positivos/Negativos) o numeros con coma", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
