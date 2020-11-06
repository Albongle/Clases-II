using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace Ejercicio_N61
{
    public partial class frmEjercicio61 : Form
    {
        private int idSeleccionado;
        private string nombreMod;
        private string apellidoMod;
        private Persona persona;
        public frmEjercicio61()
        {
            InitializeComponent();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.persona = new Persona(this.txtNombre.Text, this.txtApellido.Text);
            PersonaDAO.Guardar(persona);
            MessageBox.Show("Se guardo una Persona", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnLeer_Click(object sender, EventArgs e)
        {
            List<Persona> personas = PersonaDAO.Leer();
            foreach (Persona persona in personas)
            {
                this.lstPersonas.Items.Add(persona);
            }
        }
        private void lstPersonas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.txtNombre.Text=((Persona)this.lstPersonas.SelectedItem).Nombre;
            this.txtApellido.Text = ((Persona)this.lstPersonas.SelectedItem).Apellido;
            this.idSeleccionado = ((Persona)this.lstPersonas.SelectedItem).Id;
            this.nombreMod = this.txtNombre.Text;
            this.apellidoMod = this.txtApellido.Text;
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            PersonaDAO.Borrar(this.idSeleccionado);
            MessageBox.Show($"Se Elimino {this.txtNombre.Text}, {this.txtApellido.Text} de la BD", "Borrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.lstPersonas.Items.Clear();
            this.txtApellido.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
            this.btnLeer_Click(sender, e);
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            PersonaDAO.Modificar(this.idSeleccionado, this.txtNombre.Text, this.txtApellido.Text);
            MessageBox.Show($"Se Modifico {this.nombreMod}, {this.apellidoMod} de la BD", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.lstPersonas.Items.Clear();
            this.txtApellido.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
            this.btnLeer_Click(sender, e);
        }
    }
}
