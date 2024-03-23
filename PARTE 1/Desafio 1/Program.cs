using System;

namespace Desafíos_Semana_7
{
    public class Calculadora
{
    public string Marca { get; set; }
    public string Serie { get; set; }

    public double Sumar(double a, double b)
    {
        return a + b;
    }

    public double Restar(double a, double b)
    {
        return a - b;
    }

    public double Multiplicar(double a, double b)
    {
        return a * b;
    }

    public double Dividir(double a, double b)
    { 
        if (b == 0)
        {
            Console.WriteLine("No se puede dividir por cero.");
            return double.NaN;
        }
        return a / b;
    }
}
public class CalculadoraCientifica : Calculadora
{
    public double Potencia(double a, double b)
    {
        return Math.Pow(a, b);
    }

    public double Raiz(double a)
    {
        return Math.Sqrt(a);
    }

    public double Modulo(double a, double b)
    {
        return a % b;
    }

    public double Logaritmo(double a, double newBase)
    {
        return Math.Log(a, newBase);
    }
    }

class Program
{
    static void Main(string[] args)
    {
        Calculadora miCalculadora = new Calculadora();
        miCalculadora.Marca = "Calculadora";
        miCalculadora.Serie = "12345";

        CalculadoraCientifica miCalculadoraCientifica = new CalculadoraCientifica();
        miCalculadoraCientifica.Marca = "Calculando";
        miCalculadoraCientifica.Serie = "12345";

        double resultadoSuma = miCalculadora.Sumar(5, 3);
        double resultadoPotencia = miCalculadoraCientifica.Potencia(2, 3);

        Console.WriteLine("Resultado de la suma: " + resultadoSuma);
        Console.WriteLine("Resultado de la potencia: " + resultadoPotencia);
    }
}
}
