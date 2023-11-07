using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_02
{
    internal class Pedido : PROYECTO_02
    {
        double resultado = 0;
        char sigMoneda;

        //Se realiza un condicion en la cual se le asignan diferentes montos segun la cantidad de personas 
        //Por ultimo se realiza el calculo y se añade un mensaje 
        public string calculo()
        {
            try
            {
                if (_NumPersonas >= 200 & _NumPersonas <=300)
                {
                    _Precio = 85.00;
                    
                }
                else if (_NumPersonas > 300 )
                {
                    _Precio = 75.00;
                }
                else
                {
                    _Precio = 95.00;
                }

                resultado = _NumPersonas * _Precio;
                sigMoneda = '$';

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error:" + ex.Message);
            }

            return "El presupuesto para el pedido de: " + _Pedido + " para una cantidad de: " + _NumPersonas + " personas es de: " + sigMoneda + resultado.ToString() ;
        }

        public Pedido(string NomBanquete, int CanPersonas)
        {
            _Pedido = NomBanquete;
            _NumPersonas = CanPersonas;
            
        }
    }
}
