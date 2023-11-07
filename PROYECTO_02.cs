using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_02
{
    internal class PROYECTO_02
    {
        // Creacion de las variables
        private string pedido;
        private int numPersonas;
        private double precio;
       

        // Se crea el encapsulamiento
        protected string _Pedido { get => pedido; set => pedido = value; }
        protected int _NumPersonas { get => numPersonas; set => numPersonas = value; }
        protected double _Precio { get => precio; set => precio = value; }

        // Se crean un contructor con sus parametros
        public PROYECTO_02(string rePedido, int nPersonas,double cobro, string nomPedido) 
        {
            this.pedido = rePedido;
            this.numPersonas = nPersonas;
            this.precio = cobro;
           

        }

        // Se crean las parametros para las textbox
        public KeyPressEventArgs validarNumeros(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            return e;
        }

        public PROYECTO_02() 
        {

        }

    }
}
