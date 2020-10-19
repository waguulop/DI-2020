using POOConsola;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POOWindowsForm
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

        }

        public void imprimirObjetos()
        {

        }

        private void labelResNombre_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdelante_Click(object sender, EventArgs e)
        {
            Cuenta nuevacuenta = new Cuenta(345322317684, "Guillermo Santamaría Quesada", 195321.45, 5);
            CuentaAhorro nuevacuentaAhorro = new CuentaAhorro(345322237684, "Pepe", 9531.45, 8, 2.5);
        }
    }
}
