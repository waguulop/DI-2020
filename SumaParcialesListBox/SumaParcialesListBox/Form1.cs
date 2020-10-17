using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumaParcialesListBox
{
    public partial class VistaPrincipal : Form
    {
        public VistaPrincipal()
        {
            InitializeComponent();
        }

        private void botonCalcular_Click(object sender, EventArgs e)
        {
            int numerointroducido = Convert.ToInt32(this.updownNumeroIntroducido.Value);
            sumarNumeros(numerointroducido);
        }

        private void imprimirResultadoFinal(int resultado)
        {

            this.listaSumas.Items.Add("La suma TOTAL es " + resultado);
        }
        private void imprimirResultados(int resultado, int i)
        {
            if (this.checkBoxVerResultadosParciales.Checked == true)
            {
                this.listaSumas.Items.Add("Sumando: " + i + "Suma parcial: " + resultado);
            }
            else
            {
                this.listaSumas.Items.Add("Sumando: " + i);
            }
        }

        private void sumarNumeros(int numerointroducido)
        {
            int resultado = 0;
            for (int i = 0; i <= numerointroducido; i++)
            {
                resultado += i;
                imprimirResultados(resultado, i);
            }

            imprimirResultadoFinal(resultado);
        }
    }
}
