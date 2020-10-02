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
using ControlCantina;


namespace FrmCantina
{
    public partial class FrmCantina : Form
    {
        public FrmCantina()
        {
            InitializeComponent();
        }

        private void FrmCantina_Load(object sender, EventArgs e)
        {
            this.barra.SetCantina = Cantina.GetCantina(10);
            this.cmbBotellaTipo.DataSource = Enum.GetValues(typeof(Botella.Tipo));            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Botella.Tipo tipo;
            Enum.TryParse<Botella.Tipo>(cmbBotellaTipo.SelectedValue.ToString(), out tipo);
            if(this.rbCerveza.Checked==true)
            {
                this.barra.AgregarBotella(new Cerveza((int)this.nUpDCapacidad.Value, this.txtMarca.Text, tipo, (int)this.nUpDContenido.Value));
            }
            else
            {
                this.barra.AgregarBotella(new Agua((int)this.nUpDCapacidad.Value, this.txtMarca.Text, (int)this.nUpDContenido.Value));
            }
        }
    }
}
