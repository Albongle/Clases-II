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
using System.Xml.Schema;
using IO;

namespace Ejercicio_N56
{
    public partial class frmEditorTexto : Form
    {
        private string path = string.Empty;
        private int tipoArchivo = 0;
        public frmEditorTexto()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt|dat files (*.dat)|*.dat";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.path = openFileDialog.FileName;
                this.tipoArchivo = openFileDialog.FilterIndex;
                switch (this.tipoArchivo)
                {
                    case 1:
                        {
                            PuntoTxt archivo = new PuntoTxt();
                            this.rchtbCajaDetexto.Text = archivo.Leer(this.path);
                            break;
                        }
                    case 2:
                        {
                            PuntoDat archivo = new PuntoDat();
                            this.rchtbCajaDetexto.Text = (archivo.Leer(this.path)).Contenido;
                            break;
                        }
                }
            }
        }

        private void rchtbCajaDetexto_TextChanged(object sender, EventArgs e)
        {
            this.toolStatus.Text = "Caracteres: " + this.rchtbCajaDetexto.Text.Length;
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(this.path)))
            {
                switch (this.tipoArchivo)
                {
                    case 1:
                        {
                            PuntoTxt archivo = new PuntoTxt();
                            archivo.Guardar(this.path, this.rchtbCajaDetexto.Text);
                            break;
                        }
                    case 2:
                        {
                            PuntoDat archivo = new PuntoDat();
                            archivo.Contenido = this.rchtbCajaDetexto.Text;
                            archivo.Guardar(this.path, archivo);
                            break;
                        }
                }
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
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|dat files (*.dat)|*.dat";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.path = saveFileDialog.FileName;
                this.tipoArchivo = saveFileDialog.FilterIndex;
                switch (this.tipoArchivo)
                {
                    case 1:
                        {
                            PuntoTxt archivo = new PuntoTxt();
                            archivo.GuardarComo(this.path, this.rchtbCajaDetexto.Text);
                            break;
                        }
                    case 2:
                        {
                            PuntoDat archivo = new PuntoDat();
                            archivo.Contenido = this.rchtbCajaDetexto.Text;
                            archivo.GuardarComo(this.path, archivo);
                            break;
                        }
                }
            }
        }
    }
}
