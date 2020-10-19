using System;
using System.Collections.Generic;
using System.Text;

namespace POOConsola
{
    class CuentaAhorro : Cuenta
    {
        private double cuotaMantenimiento;

        public CuentaAhorro(long numCuenta, string nombre, double saldo, int tipoInteres, double cuotaMantenimiento) : base (numCuenta, nombre, saldo, tipoInteres)
        {
            CuotaMantenimiento = cuotaMantenimiento;
        }

        public double CuotaMantenimiento { get => cuotaMantenimiento; set => cuotaMantenimiento = value; }
        public override void estado()
        {
            Console.WriteLine("Cuota Mantenimiento: " + this.CuotaMantenimiento);
            base.estado();
        }
    }
}
