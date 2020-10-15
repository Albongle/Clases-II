using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace PrimerParcial
{
    public partial class FrmBar : Form
    {
        protected Bar nuevoBar;
        public FrmBar()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random edadRandom = new Random();
            nuevoBar= Bar.GetBar();
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            FrmInforme informe = new FrmInforme(nuevoBar);
            informe.ShowDialog();
        }

        private void nUpDEmpleado_ValueChanged(object sender, EventArgs e)
        {
            
            if(nuevoBar.Empleados.Count< (int)this.nUpDEmpleado.Value)
            {
                FrmDatos cargarDatos = new FrmDatos(nuevoBar,"Empleado");
                cargarDatos.ShowDialog();
            }
            else if (nuevoBar.Empleados.Count>0)
            {
                MessageBox.Show("Se Elimino un Empleado", "Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nuevoBar.Empleados.RemoveAt(nuevoBar.Empleados.Count-1);
            }

        }
        private void nUpDGente_ValueChanged(object sender, EventArgs e)
        {
            if (nuevoBar.Gente.Count < (int)this.nUpDGente.Value)
            {
                FrmDatos cargarDatos = new FrmDatos(nuevoBar, "Gente");
                cargarDatos.ShowDialog();
            }
            else if (nuevoBar.Gente.Count>0)
            {
                MessageBox.Show("Se Elimino una nueva persona", "Gente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nuevoBar.Gente.RemoveAt(0);
            }      
        }
    }
}
