using System;

namespace Empresa
{
    // Classe abstrata
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public double SalarioBase { get; set; }

        public Funcionario(string nome, double salarioBase)
        {
            Nome = nome;
            SalarioBase = salarioBase;
        }

        // Método abstrato
        public abstract double CalcularSalario();
    }

    // Funcionário CLT
    public class CLT : Funcionario
    {
        public CLT(string nome, double salarioBase) : base(nome, salarioBase) {}

        public override double CalcularSalario()
        {
            // Desconto de INSS e FGTS fictícios
            double desconto = SalarioBase * 0.3;
            return SalarioBase - desconto;
        }
    }

    // Funcionário PJ
    public class PJ : Funcionario
    {
        public PJ(string nome, double salarioBase) : base(nome, salarioBase) {}

        public override double CalcularSalario()
        {
            // PJ não tem desconto no exemplo
            return SalarioBase;
        }
    }

    // Programa principal para testar
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario1 = new CLT("João", 5000);
            Funcionario funcionario2 = new PJ("Maria", 5000);

            Console.WriteLine($"{funcionario1.Nome} (CLT) recebe: R$ {funcionario1.CalcularSalario()}");
            Console.WriteLine($"{funcionario2.Nome} (PJ) recebe: R$ {funcionario2.CalcularSalario()}");
        }
    }
}
