public abstract class Empleado
{
    public string Nombre { get; set; }
    public bool AlcanzadoMeta { get; set; }

    // Método abstracto para calcular el salario
    public abstract decimal CalcularSalario();

    // Constructor
    public Empleado(string nombre, bool alcanzadoMeta)
    {
        Nombre = nombre;
        AlcanzadoMeta = alcanzadoMeta;
    }
}
