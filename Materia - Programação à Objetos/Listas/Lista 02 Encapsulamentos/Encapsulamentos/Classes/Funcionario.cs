namespace Classes;

public class Funcionario
{
    public string? Nome { get; }
    public double SalarioBruto { get; }
    public double Desconto { get; }

    public Funcionario(string nome, double salario, double desconto)
    {
        Nome = nome;
        SalarioBruto = salario;
        Desconto = desconto;
    }
    public double CalcularSalarioLiquido()
    {
        return SalarioBruto - Desconto;
    }
    public double SalarioLiquido => SalarioBruto - Desconto;
}