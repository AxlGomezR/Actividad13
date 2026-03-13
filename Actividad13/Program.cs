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
        if(((rendimiento1 + rendimiento2 + rendimiento3) / 3)>= 80){
            return "Óptimo";
        }
        else
        {
            return "Necesita mantenimiento";
        }
    }
}