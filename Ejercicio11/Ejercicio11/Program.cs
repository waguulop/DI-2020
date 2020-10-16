using System;
using System.Collections;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumnocontrolador = new Alumno("Controlador", 99);
            alumnocontrolador.pedirAlumnos();
        }
    }

    class Alumno
    {
        private String nombre;
        private int edad;
        private Alumno[] arrayAlumnos = new Alumno[6];
        private int cantidadAlumnos = 0;

        public Alumno(String nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public void imprimirResultados()
        {
            imprimirMayoresDeEdad();
            alumnoMasViejo();
        }

        public void imprimirMayoresDeEdad()
        {
            Console.WriteLine("Alumnos mayores de edad: ");
            for (int i = 0; i < this.cantidadAlumnos; i++)
            {
                if (this.arrayAlumnos[i].edad >= 18)
                {
                    Console.Write(arrayAlumnos[i].nombre);
                }           
            }
        }

        public void alumnoMasViejo()
        {
            int masviejo = 0;
            int posicionviejo = 0;
            for (int i = 0; i < this.cantidadAlumnos; i++)
            {
                if (this.arrayAlumnos[i].edad > masviejo)
                {
                    masviejo = arrayAlumnos[i].edad;
                    posicionviejo = i;
                }
            }

            Console.WriteLine("El alumno más viejo es " + this.arrayAlumnos[posicionviejo].nombre);
        }

        public void pedirAlumnos()
        {
            while (this.cantidadAlumnos < 5)
            {
                Console.WriteLine("Introduce el nombre del alumno: ");
                String nombreAlumno = Console.ReadLine();
                if (nombreAlumno != "*")
                {
                    Console.WriteLine("Introduce la edad: ");
                    int edad = System.Convert.ToInt32(System.Console.ReadLine());
                    Alumno nuevoalumno = new Alumno(nombreAlumno, edad);
                    this.arrayAlumnos[this.cantidadAlumnos] = nuevoalumno;
                    this.cantidadAlumnos++;
                }
                else
                {
                    Console.WriteLine("Cerrando proceso de creacion de usuarios...");
                    imprimirResultados();
                    break;
                }
            }
        }
    }
}
