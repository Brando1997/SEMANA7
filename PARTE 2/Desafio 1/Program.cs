using System;
using System.Collections.Generic;
using System.IO;

public class Auto
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    private List<string> reparaciones; 

    public Auto(string marca, string modelo)
    {
        Marca = marca;
        Modelo = modelo;
        reparaciones = new List<string>();
    }

    public void HistoriaDeReparaciones(string reparacion)
    {
        reparaciones.Add(reparacion);
    }

    public void ImprimirHistoriaDeReparaciones()
    {
        Console.WriteLine($"Historia de reparaciones del {Marca} {Modelo}:");
        foreach (var reparacion in reparaciones)
        {
            Console.WriteLine(reparacion);
        }
    }
}

public class BMW : Auto
{
    public BMW(string modelo) : base("BMW", modelo)
    {
    }

    public void Reparar(string reparacion)
    {
        using (StreamWriter writer = new StreamWriter("reparaciones_bmw.txt", true))
        {
            writer.WriteLine(reparacion);
        }
    }

    public new void ImprimirHistoriaDeReparaciones()
    {
        Console.WriteLine($"Historia de reparaciones del BMW {Modelo} desde archivo:");
        using (StreamReader reader = new StreamReader("reparaciones_bmw.txt"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        BMW miBMW = new BMW("Serie 3");

        miBMW.Reparar("Cambio de aceite");
        miBMW.Reparar("Cambio de frenos");

        miBMW.ImprimirHistoriaDeReparaciones();

        miBMW.HistoriaDeReparaciones("Reparación de faros");

        miBMW.ImprimirHistoriaDeReparaciones();
    }
}