using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormPila
{
    public partial class Form1 : Form
    {
        Pila pila;
        public Form1(int capmax)
        {
            pila = new Pila(capmax);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnapilar_Click(object sender, EventArgs e)
        {
            if (this.txtnumero.Text != "")
            {
                int dato = int.Parse(this.txtnumero.Text);
                pila.ApilarPila(dato);
                listarpila();
                MostrarDatos();

            }
            else
            {
                MessageBox.Show("DIGITE UN VALOR EN LA CAJA DE TEXTO");
            }

            this.txtnumero.Text = "";

        }

        private void btndesapilar_Click(object sender, EventArgs e)
        {
            pila.DesapilarPila();
            listarpila();
            MostrarDatos();

        }

        private void btnvaciarpila_Click(object sender, EventArgs e)
        {
            pila.VaciarPila();
            MostrarDatos();
            this.pilacontenedora.Items.Clear();
        }
        public void listarpila()
        {
            int[] elementos = pila.ElemetosPila();
            this.pilacontenedora.Items.Clear();
            for (int i=elementos.Length-1; i>=0; i--)
            {
                if (elementos[i] != 0)
                {
                    this.pilacontenedora.Items.Add("["+i+"] => "+elementos[i]);
                }
                
            }
        }
        public void MostrarDatos()
        {
            lblpares.Text=pila.ContarElementosPares().ToString();
            lblimpares.Text = pila.ContarElementosImpares().ToString();
            lblpromedio.Text = pila.PromedioELementos().ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
