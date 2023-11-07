using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_02
{
    public partial class frmPresupuesto : Form
    {
        public frmPresupuesto()
        {
            InitializeComponent();
        }

        private void grbPedidos_Enter(object sender, EventArgs e)
        {

        }

        private void frmPresupuesto_Load(object sender, EventArgs e)
        {
           
        }

        private void txtNumPersonas_TextChanged(object sender, EventArgs e)
        { }


        // Se asigna la funcion al boton salir
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Se crea una funcion de limpiar y luego se llama al boton limpiar y se le asigna dicha funcion
        public void limpiar ()
        {
            txtPedido.Clear();
            txtNumPersonas.Clear();
            txtPedido.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        // Se le asigna una funcion al boton de Menu, que muestra una lista con todos los banquetes
        private void btnMenu_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("file:///C:/Users/AMD/OneDrive/Documentos/LA%20LANGOSTA%20AHUMADA.pdf");
        }

        // Se crea la funcion convertir y se llaman a la clase hija Pedido, la cual realiza el calculo de la cotizacion
        public void convertir()
        {
            string NombrePedido = txtPedido.Text;
            int NumeroPersonas = Convert.ToInt32(txtNumPersonas.Text);
            
            Pedido calcular = new Pedido(NombrePedido, NumeroPersonas);

            MessageBox.Show(calcular.calculo(),"Cotizacion del pedido realizado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            convertir();
        }

        // Se le asigan los parametros para el txtNumPersonas y se llama a la clase Padre PROYECTO_02
        private void txtNumPersonas_KeyPress(object sender, KeyPressEventArgs e)
        {
            PROYECTO_02 validar = new PROYECTO_02();
            validar.validarNumeros(e);
        }
    }
}
