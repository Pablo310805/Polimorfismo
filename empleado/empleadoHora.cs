
    public class empleadoHora : Empleado
    {
         public int HorasTrabajadas { get; set; }
    private const decimal TarifaPorHora = 800;

    public empleadoHora(string nombre, bool alcanzadoMeta, int horasTrabajadas)
        : base(nombre, alcanzadoMeta)
    {
        HorasTrabajadas = horasTrabajadas;
    }
    
    public override decimal CalcularSalario()
    {
        return HorasTrabajadas * TarifaPorHora;
    }
    }
