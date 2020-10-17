using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosteGastosDeEnvio
{
    public partial class VistaPrincipal : Form
    {
        public VistaPrincipal()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void botonRealizarPedido_Click(object sender, EventArgs e)
        {
            int indice = this.checkedListBoxEnvio.SelectedIndex;
            if (indice > 1)
            {
                MessageBox.Show("Lo siento, solo se puede seleccionar un método de envio");
            }
            else
            {
                this.labelResultadoPrecioTotal.Text = calcularPrecioTotal().ToString();
            }
        }

        private double calcularPrecioTotal()
        {
            double precioTotal = 0;

            if (this.checkedListBoxEnvio.GetItemChecked(0) == true)
                precioTotal += 1.90;          
            else if (this.checkedListBoxEnvio.GetItemChecked(1) == true)
                precioTotal += 2.99;           
            else if (this.checkedListBoxEnvio.GetItemChecked(2) == true)
                precioTotal += 4.99;


            if (this.checkedListBoxNotificacion.GetItemChecked(0) == true)
                precioTotal += 0.50;
            else if (this.checkedListBoxNotificacion.GetItemChecked(1) == true)
                precioTotal += 0.70;
            else if (this.checkedListBoxNotificacion.GetItemChecked(2) == true)
                precioTotal += 1.00;

            return precioTotal;
        }
    }
}
