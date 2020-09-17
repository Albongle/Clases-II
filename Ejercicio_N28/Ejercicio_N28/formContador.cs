using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_N28
{
    public partial class frmContador : Form
    {
        public frmContador()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string[] palabrasAux = new string[(this.rtbCajaDetexto.Text.Split(' ')).Length]; // declaro un array de string del tamaño de arrays que puedo generar desde el ingreso del RichText
            palabrasAux = this.rtbCajaDetexto.Text.Split(' '); // le cargo el texto ingresado en forma de array
            Dictionary<string, int> diccionario= new Dictionary<string, int>();
            List<KeyValuePair<string, int>> listaAuxiliar; // declaro una lista de tipo keyvaluepair en donde voy a guardar la lista diccionario
            foreach (string palabra in palabrasAux)
            {              
                if(!(diccionario.ContainsKey(palabra.ToUpper())) && !(string.IsNullOrEmpty(palabra))) // me fijo que la palabra este no este en la lista y esta no sea null o vacia
                {
                    diccionario.Add(palabra.ToUpper(), 1);
                }
                else if (!(string.IsNullOrEmpty(palabra)))
                {
                    diccionario[palabra.ToUpper()] = diccionario[palabra.ToUpper()] + 1;
                }
            }
            listaAuxiliar = diccionario.ToList();
            listaAuxiliar.Sort(FuncionCriterio);
            for (int i = 0; i < 4; i++)
            {
                MessageBox.Show("La palabra " + listaAuxiliar[i].Key + " se repitio " + listaAuxiliar[i].Value, "Palabra", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private int FuncionCriterio (KeyValuePair<string, int> primerValor, KeyValuePair<string, int> segundoValor)
        {
            int returnAux = 0;
            if(primerValor.Value> segundoValor.Value)
            {
                returnAux = -1;
            }
            else if (primerValor.Value < segundoValor.Value)
            {
                returnAux = 1;
            }
            return returnAux;
        }

    }
}
