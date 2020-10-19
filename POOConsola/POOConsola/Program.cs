using System;

namespace POOConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta nuevacuenta = new Cuenta(345322317684, "Guillermo Santamaría Quesada", 195321.45, 5);
            CuentaAhorro nuevacuentaAhorro = new CuentaAhorro(345322237684, "Pepe", 9531.45, 8, 2.5);
            nuevacuentaAhorro.estado();
            nuevacuenta.estado();
        }
    }
}
