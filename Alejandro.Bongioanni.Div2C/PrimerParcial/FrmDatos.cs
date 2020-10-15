using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace PrimerParcial
{
    public partial class FrmDatos : Form
    {
        private Bar nuevoBar;
        private Empleado nuevoEmpleado;
        private Gente nuevoGente;
        private string flag;

        private FrmDatos(Bar bar)
        {
            InitializeComponent();
            this.nuevoBar = bar;
        }
        public FrmDatos(Bar bar, string flag)
            :this(bar)
        {
            this.flag = flag;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            short edadAux;
            int dniAux;
            short.TryParse(this.txtEdad.Text, out edadAux);
            if (this.flag=="Empleado")
            {
                int.TryParse(this.txtDni.Text, out dniAux);
                this.nuevoEmpleado = new Empleado(this.txtNombre.Text, edadAux, dniAux);
                if(this.nuevoBar+this.nuevoEmpleado)
                {
                    MessageBox.Show("Se agrego un nuevo empleado", "Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo agregar un nuevo empleado", "Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (this.flag=="Gente")
            {
                this.nuevoGente = new Gente(this.txtNombre.Text, edadAux);
                if (this.nuevoBar + this.nuevoGente)
                {
                    MessageBox.Show("Se agrego una nueva persona", "Gente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo agregar una persona", "Gente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            this.Close();
        }
    }
}
