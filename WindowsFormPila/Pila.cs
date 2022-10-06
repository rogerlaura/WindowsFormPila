using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormPila
{
    internal class Pila
    {
        private int tope, maxpila;
        private int[] contenedorpila;
        public Pila(int maxpila)
        {
            this.tope = -1;
            this.maxpila = maxpila;
            this.contenedorpila = new int[maxpila];
        }
        public bool Pilavacia()
        {
            if (this.tope == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Pilallena()
        {
            if (this.tope == maxpila - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void ApilarPila(int dato)
        {
            if (this.Pilallena() == false)
            {
                this.tope++;
                this.contenedorpila[tope] = dato;
                MessageBox.Show("SE APILO EL ELEMENTO " + this.contenedorpila[tope] + " EN LA PILA");
            }
            else
            {
                MessageBox.Show("LA PILA ESTA LLENA");
            }
        }
        public void DesapilarPila()
        {
            if (this.Pilavacia() == false)
            {
                MessageBox.Show("SE DASAPILO EL ELEMENTO " + this.contenedorpila[tope] + " DE LA PILA ");
                this.contenedorpila[tope] = 0;
                this.tope--;
            }
            else
            {
                
                MessageBox.Show("LA PILA ESTA VACIA");
            }
        }
        public void VaciarPila()
        {
            if (this.Pilavacia() == false)
            {
                for (int i = 0; i <= this.tope; i++)
                {
                    this.contenedorpila[i] = 0;
                }
                this.tope = -1;
                MessageBox.Show("SE VACIO LA PILA SATISFACTORIAMENTE");
            }
            else
            {
                MessageBox.Show("LA PILA ESTA VACIA");
            }
        }
        public int[] ElemetosPila()
        {
            return this.contenedorpila;
        }

    }
}
