using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vista vistaprincipal = new Vista();
            vistaprincipal.start();
        }
    }
}

class Vista{

    private int num1;
    private int num2;
    private int respuesta_menu;
    private Operaciones opera = new Operaciones();

    public void setNum1(int num)
    {
        this.num1 = num;
    }

    public void setNum2(int num)
    {
        this.num2 = num;
    }

    public int getNum1()
    {
        return num1;
    }

    public int getNum2()
    {
        return num2;
    }

    public void start()
    {
        while (true)
        {
            this.menu();
            setNum1(0);
            setNum2(0);
            this.opera.setResultado(0);
        }
    }

    public void menu()
    {
        Console.WriteLine("1. Sumar");
        Console.WriteLine("2. Restar");
        Console.WriteLine("3. Multiplicar");
        Console.WriteLine("4. Dividir");
        Console.WriteLine("5. Salir");
        Console.WriteLine("Introduce una opcion: ");
        this.respuesta_menu = int.Parse(Console.ReadLine());
        this.pedirNumeros();
        this.respuestaMenu();
    }

    public void respuestaMenu()
    {

        if (this.respuesta_menu == 1)
        {
            this.opera.Sumar(this.num1, this.num2);
        }
        else if (this.respuesta_menu == 2)
        {
            this.opera.Restar(this.num1, this.num2);
        }
        else if(this.respuesta_menu == 3)
        {
            this.opera.Multiplicar(this.num1, this.num2);
        }
        else if(this.respuesta_menu == 4){
            this.opera.Dividir(this.num1, this.num2);
        }
        else if (this.respuesta_menu == 5)
        {
            
        }

        this.mostrarResultado();
    }

    public void mostrarResultado()
    {
        Console.WriteLine("El resultado es :" + this.opera.getResultado());
    }

    public void pedirNumeros()
    {
        Console.WriteLine("Introduce el primer numero : ");
        setNum1(int.Parse(Console.ReadLine()));
        Console.WriteLine("Introduce el segundo numero : ");
        setNum2(int.Parse(Console.ReadLine()));
    }
}

public class Operaciones{
    private int resultado;

    public void setResultado(int res)
    {
        this.resultado = res;
    }

    public int getResultado()
    {
        return this.resultado;
    }

    public void Sumar(int num1, int num2)
    {
        setResultado(num1 + num2);
    }

    public void Restar(int num1, int num2)
    {
        setResultado(num1 - num2);
    }

    public void Dividir(int num1, int num2)
    {
        setResultado(num1 / num2);
    }

    public void Multiplicar(int num1, int num2)
    {
        setResultado(num1 * num2);
    }
}
