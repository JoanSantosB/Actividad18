class Empleado
{
    private double salario;
    public string Salario
    {
        get
        {
            if (salario > 3843.55) return $"Salario: {salario}";
            else return "Salario inválido";
        }
    }
}