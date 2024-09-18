public class EmpleadoAdministrativo : Empleado
{
    public decimal SalarioBase { get; set; }

    public EmpleadoAdministrativo(string nombre, bool alcanzadoMeta, decimal salarioBase)
        : base(nombre, alcanzadoMeta)
    {
        SalarioBase = salarioBase;
    }

    public override decimal CalcularSalario()
    {
        return AlcanzadoMeta ? SalarioBase : SalarioBase / 2;
    }
}