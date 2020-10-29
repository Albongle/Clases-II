using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace Ejercicio_N56
{
    public partial class frmEditorTexto : Form
    {
        private string path= string.Empty;
        public frmEditorTexto()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog()==DialogResult.OK)
            {
                this.path = openFileDialog.FileName;
                this.rchtbCajaDetexto.Text = FileManager.LeerArchivoTexto(this.path);
            }
        }

        private void rchtbCajaDetexto_TextChanged(object sender, EventArgs e)
        {
           this.toolStatus.Text ="Caracteres: " + this.rchtbCajaDetexto.Text.Length;
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!(string.IsNullOrWhiteSpace(this.path)))
            {
                FileManager.EscribirArchivoTexto(this.path, this.rchtbCajaDetexto.Text, false);
            }
            else 
            {
                this.GuardarArchivo(this.rchtbCajaDetexto.Text);
            }            
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.GuardarArchivo(this.rchtbCajaDetexto.Text);
        }
        private void GuardarArchivo(string texto)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files(*.txt)| *.txt | All files(*.*) | *.* ";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.path = saveFileDialog.FileName;
                FileManager.EscribirArchivoTexto(this.path, texto, false);
            }
        }
    }
}
