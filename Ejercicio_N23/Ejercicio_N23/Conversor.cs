using Ejercicio_N23.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Billetes;

namespace Ejercicio_N23
{
    public partial class FormConversor : Form
    {
        private static int flagImagen =0;
        public FormConversor()
        {
            InitializeComponent();
        }
        private void LockText(int flag)
        {
            if(flag<1)
            {            
                Peso.SetCotizacion = textCotizacionPeso.Text;
                textCotizacionDolar.Enabled = false;
                textCotizacionEuro.Enabled = false;
                textCotizacionPeso.Enabled = false;
                flagImagen = 1;
                this.buttonLockCotizacion.ImageIndex = 0;
            }
            else
            {
                textCotizacionDolar.Enabled = true;
                textCotizacionEuro.Enabled = true;
                textCotizacionPeso.Enabled = true;
                flagImagen = 0;
                this.buttonLockCotizacion.ImageIndex = 1;
            }
            
        }
        private void btnEuroConvert_Click(object sender, EventArgs e)
        {
            Euro billete= this.txtCantidadEuro.Text;
            this.txtEuroDolar.Text = ((Dolar)billete).GetCantidad().ToString("0.0");
            this.txtEuroEuro.Text = billete.GetCantidad().ToString("0.0");
            this.txtEuroPeso.Text = ((Peso)billete).GetCantidad().ToString("0.0");
        }
        private void btnDolarConvert_Click(object sender, EventArgs e)
        {
            Dolar billete = this.txtCantidadDolar.Text;
            this.txtDolarDolar.Text = billete.GetCantidad().ToString("0.0");
            this.txtDolarEuro.Text = ((Euro)billete).GetCantidad().ToString("0.0");
            this.txtDolarPeso.Text = ((Peso)billete).GetCantidad().ToString("0.0");
        }
        private void btnPesoConvert_Click(object sender, EventArgs e)
        {
            Peso billete = this.txtCantidadPeso.Text;
            this.txtPesoPeso.Text = billete.GetCantidad().ToString("0.0");
            this.txtPesoDolar.Text = ((Dolar)billete).GetCantidad().ToString("0.0");
            this.txtPesoEuro.Text = ((Euro)billete).GetCantidad().ToString("0.0");
        }
        private void buttonLockCotizacion_Click(object sender, EventArgs e)
        {
            LockText(flagImagen);
        }
        private void textEuro_Leave(object sender, EventArgs e)
        {
            Euro.SetCotizacion = textCotizacionEuro.Text;
            if (Euro.GetCotizacion() == -1)
            {
                this.textCotizacionEuro.Focus();
            }
        }
        private void textCotizacionDolar_Leave(object sender, EventArgs e)
        {
            Dolar.SetCotizacion = textCotizacionDolar.Text;
            if (Dolar.GetCotizacion() == -1)
            {
                this.textCotizacionDolar.Focus();
            }
        }
        private void textCotizacionPeso_Leave(object sender, EventArgs e)
        {
            Peso.SetCotizacion = textCotizacionPeso.Text;
            if (Dolar.GetCotizacion() == -1)
            {
                this.textCotizacionPeso.Focus();
            }
        }
    }
}
