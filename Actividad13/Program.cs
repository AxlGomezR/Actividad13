class Dispositivos
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