using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaquinaRefrescos
{
    public partial class VentanaPrincipalVentaRefrescos : Form
    {
        private Bebida[] arrayBebidas = new Bebida[6];
        private int bebidaEscogida = -1;
        public VentanaPrincipalVentaRefrescos()
        {
            InitializeComponent();
            this.arrayBebidas[0] = new Bebida("Cocacola", 1.00);
            this.arrayBebidas[1] = new Bebida("Fanta", 1.00);
            this.arrayBebidas[2] = new Bebida("Aquarius", 0.90);
            this.arrayBebidas[3] = new Bebida("Sprite", 1.20);
            this.arrayBebidas[4] = new Bebida("Monster", 1.50);
            this.arrayBebidas[5] = new Bebida("Agua", 0.40);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private String imprimirBebida(int i) { return this.labelNombreBebidaYPrecio.Text = this.arrayBebidas[i].getNombre() + " " + this.arrayBebidas[i].getPrecio() + "€"; }
        private void imprimirCambio(Double cambio) { this.labelresultadoCambio.Text = Convert.ToString(cambio); }
        private void botonCocacola_Click(object sender, EventArgs e)
        {
            imprimirBebida(0);
            this.bebidaEscogida = 0;
        }

        private void botonFantaNaranja_Click(object sender, EventArgs e)
        {
            imprimirBebida(1);
            this.bebidaEscogida = 1;
        }
        private void botonAquarius_Click(object sender, EventArgs e)
        {
            imprimirBebida(2);
            this.bebidaEscogida = 2;
        }

        private void botonSprite_Click(object sender, EventArgs e)
        {
            imprimirBebida(3);
            this.bebidaEscogida = 3;
        }

        private void botonMonster_Click(object sender, EventArgs e)
        {
            imprimirBebida(4);
            this.bebidaEscogida = 4;
        }

        private void botonAgua_Click(object sender, EventArgs e)
        {
            imprimirBebida(5);
            this.bebidaEscogida = 5;
        }

        private void filtroBebida()
        {
            if (this.bebidaEscogida == -1)
            {
                this.labelExcepcion.Text = "Por favor, selecciona una bebida e ingresa dinero";
            }
        }
        
        private void botonComprarBebida_Click(object sender, EventArgs e)
        {
            if (this.cajaDineroAIngresar.Text != "" && this.bebidaEscogida != -1)
            {
                imprimirCambio(calcularCambio(this.arrayBebidas[this.bebidaEscogida]));
            }
            else
            {
                filtroBebida();
            }
        }
        
        private double calcularCambio(Bebida bebidaescogida)
        {
            double cambio = 0;

            cambio = bebidaescogida.getPrecio() - Convert.ToDouble(this.cajaDineroAIngresar.Text);

            return cambio;
        }

        private void botonRecogerCambio_Click(object sender, EventArgs e)
        {
            this.labelresultadoCambio.Text = "";
            this.cajaDineroAIngresar.Text = "";
        }

        private void panelVenta_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
