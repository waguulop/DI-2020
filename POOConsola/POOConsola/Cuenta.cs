using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace POOConsola
{
    class Cuenta
    {
        private long numCuenta;
        private String nombre;
        private double saldo;
        private int tipoInteres;
        
        public Cuenta(long numCuenta, string nombre, double saldo, int tipoInteres)
        {
            NumCuenta = numCuenta;
            Nombre = nombre;
            Saldo = saldo;
            TipoInteres = tipoInteres;
        }

        public long NumCuenta { get => numCuenta; set => numCuenta = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Saldo { get => saldo; set => saldo = value; }
        public int TipoInteres { get => tipoInteres; set => tipoInteres = value; }

        public virtual void estado()
        {
            Console.WriteLine("Numero de cuenta: " + this.NumCuenta);
            Console.WriteLine("Nombre: " + this.Nombre);
            Console.WriteLine("Saldo: " + this.Saldo);
            Console.WriteLine("Tipo interes: " + this.TipoInteres);
        }
    }
}
