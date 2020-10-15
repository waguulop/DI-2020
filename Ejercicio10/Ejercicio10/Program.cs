using System;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            realizarPreguntasRandom();
        }

        public static void realizarPreguntasRandom()
        {
            int puntos = 0;
            while (puntos < 5)
            {
                Console.Write("PUNTOS ACTUALES [" + puntos + "] Siguiente pregunta: ");
                int num_pregunta = generarNumeroRandom();
                Console.WriteLine(listaPreguntas(num_pregunta));
                Console.WriteLine("Escribe tu respuesta (con letras minúsculas): ");
                String respuesta = Console.ReadLine();
                puntos += recalcularPuntos(num_pregunta, respuesta);
                imprimirResultadoRespuesta(num_pregunta, respuesta);
            }

            Console.WriteLine("El juego ha terminado, ¡gracias por jugar!");
        }

        public static void imprimirResultadoRespuesta(int num_pregunta, String respuesta)
        {
            if (comprobarRespuesta(num_pregunta, respuesta) == true)
            {
                Console.WriteLine("* RESPUESTA CORRECTA *");
            }
            else
            {
                Console.WriteLine("¡ RESPUESTA INCORRECTA !");
            }
        }

        public static int recalcularPuntos(int num_pregunta, String respuesta)
        {
            int puntos = 0;
            if (comprobarRespuesta(num_pregunta, respuesta) == true)
            {
                puntos = 2;
            }
            else
            {
                puntos = -1;
            }

            return puntos;
        }

        public static int generarNumeroRandom()
        {
            Random rnd = new Random();
            int preguntaRandom = rnd.Next(1, 6);
            return preguntaRandom;
        }

        public static bool comprobarRespuesta(int num_pregunta, String respuesta)
        {
            int num_respuesta = -1;
            Boolean encontrada = false;
            for (int i = 0; i < 6; i++)
            {
                if (respuesta == listaRespuestas(i))
                {
                    num_respuesta = i;
                }

                if (num_respuesta == num_pregunta)
                {
                    encontrada = true;
                }
            }

            return encontrada;
        }

        public static String listaPreguntas(int i)
        {
            String [] preguntas = {"¿Qué animal es un felino y se puede tener como mascota?",
                                    "¿Cuantas patas tiene un pato?",
                                    "¿Qué componente esencial tiene la leche?",
                                    "¿Cuantas teclas (minimo) tiene un ordenador?",
                                    "¿Como se llama el cerebro del ordenador?",
                                    "¿Que marca creó Bill Gates?"};
            return preguntas[i];
        }

        public static String listaRespuestas(int i)
        {
            String[] respuestas = {"gato","2","calcio","64","cpu","apple"};
            return respuestas[i];
        }
    }
}
