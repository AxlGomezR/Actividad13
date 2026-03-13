using System;
using System.Collections.Generic;   
List<Dispositivo> dispositivos = new List<Dispositivo>();
bool continuar = false;
int cantidad;
do
{
    Console.WriteLine("Ingrese la cantidad de dispositivos que registrará");
    cantidad=int.Parse(Console.ReadLine());
    Console.Clear();
    if (cantidad <= 0)
    {
        Console.WriteLine("Debe registrar al menos 1 dispositivo");
    }
    else
    {
        continuar = true;
        for(int i =0; i<cantidad; i++)
        {
            Dispositivo d = new Dispositivo();
            Console.WriteLine($"Dispositivo {i+1}");
            Console.WriteLine("Ingrese el nombre del dispositivo"); d.nombre = Console.ReadLine();
            Console.WriteLine("\nRendimiento 1: "); d.rendimiento1= double.Parse(Console.ReadLine());
            Console.WriteLine("\nRendimiento 2: "); d.rendimiento2 = double.Parse(Console.ReadLine());
            Console.WriteLine("\nRendimiento 3: "); d.rendimiento3 = double.Parse(Console.ReadLine());
            dispositivos.Add(d);
        }
        double promedioTotal = 0;
        Dispositivo mejor = dispositivos[0];
        Console.WriteLine("Dispositivos Ingresados:\n");
        foreach(Dispositivo d in dispositivos)
        {
            d.MostrarInfo();
            promedioTotal += d.CalcularPromedio();
            if (d.CalcularPromedio() > mejor.CalcularPromedio())
            {
                mejor = d;
            }
        }
    }

} while (continuar==false);
class Dispositivo
{
    public string nombre;
    public double rendimiento1;
    public double rendimiento2;
    public double rendimiento3;

    public double CalcularPromedio()
    {
        return (rendimiento1 + rendimiento2 + rendimiento3) / 3;
    }
    public string EstadoDispositivo()
    {
        if(CalcularPromedio() >= 80){
            return "Óptimo";
        }
        else
        {
            return "Necesita mantenimiento";
        }
    }
    public void MostrarInfo()
    {
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Rendimiento 1: {rendimiento1} | Rendimiento 2: {rendimiento2} | Rendimiento 3: {rendimiento3}");
        Console.WriteLine($"Promedio del rendimiento: {CalcularPromedio()}");
        Console.WriteLine($"Estado del dispositivo: {EstadoDispositivo()}");
    }
}