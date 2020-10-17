﻿using System;
using System.Runtime.CompilerServices;

namespace MaquinaRefrescos
{
    public class Bebida{

        private String nombre;
        private double precio;

        public Bebida(string nombre, double precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }

        public String getNombre()
        {
            return this.nombre;
        }

        public double getPrecio()
        {
            return this.precio;
        }
    }
}
