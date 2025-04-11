using System.ComponentModel;
using System.Security.AccessControl;

namespace Classes;

public class Funcionario
{
    public string? Nome { get; set; }
    public double Salario { get; set; }

    public Funcionario(string? nome, double salario)
    {
        Nome = nome;
        Salario = salario;
    }

    public virtual void ExibirDados()
    {
        Console.WriteLine($"Nome = {Nome}");
        Console.WriteLine($"Salário = {Salario}");
    }
}

public class Gerente : Funcionario
{
    public Gerente(string? nome, double salario) : base(nome, salario)
    {
    }
    public bool AcessoGeral = true;
    public void BeneficioSalarial()
    {
        Salario += 500.0;
        Console.WriteLine($"Seu salário é de {Salario} senhor gerente!");
    }
    public override void ExibirDados()
    {
        Console.WriteLine($"Gerente = {Nome}");
        Console.WriteLine($"Salário = {Salario}");
        Console.WriteLine($"");
    }   
}
public class Desenvolvedor : Funcionario
{
    public Desenvolvedor(string? nome, double salario) : base(nome, salario)
    {
    }
    public void BeneficioSalarial()
    {
        Salario += 250.0;
        Console.WriteLine($"Seu salário é de {Salario} senhor clt!");
    }
    public override void ExibirDados()
    {
        Console.WriteLine($"Desenvolvedor = {Nome}");
        Console.WriteLine($"Salário = {Salario}");
    }
}

