using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace Ejercicio_N63
{
    public partial class frmThreads : Form
    {
        //Thread thread; pertenece al ejercicio 63
        Temporizador temporizador = new Temporizador();


        public frmThreads()
        {
            InitializeComponent();
        }


        private void frmThreads_Load(object sender, EventArgs e)
        {
            temporizador.EventoTiempo += ActualizarHora;
            temporizador.Intervalo = 1000;
            temporizador.Activo = true;
        }

        delegate void Callback();
        public void ActualizarHora()
        {
            if (this.lblHora.InvokeRequired)
            {
                Callback callback = new Callback(this.ActualizarHora);
                //object[] objs = new object[] { hora };
                this.Invoke(callback);
            }
            else
            {
                this.lblHora.Text = DateTime.Now.ToString();
            }
        }

        //Comentado dado que pertenece al EJ 63
        /*
        public void TraerHora()
        {
            while (true)
            {
                ActualizarHora();
            }
        }*/

        private void frmThreads_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.temporizador.Activo = false;
        }
    }
}
