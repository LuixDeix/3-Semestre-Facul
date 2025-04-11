namespace Classes;

public class ContaBancaria
{
    private int saldo;
    public int Saldo
    {
        get
        {
            return saldo;
        }
        set
        {
            if (value >= 0)
            {
                saldo = value;
            }
            else
            {
                Console.WriteLine("Defina um número Positivo!");
            }
        }
    }
    public ContaBancaria(int saldo)
    {
        Saldo = saldo;
    }

    public void Depositar()
    {
        Console.WriteLine($"Seu saldo atual é de: [{Saldo}]!");
        Console.WriteLine("O quanto desejas depositar em sua conta?");
        int valor;
        while (!int.TryParse(Console.ReadLine(), out valor) || valor < 0)
        {
            Console.WriteLine($"Digite um valor maior ou igual a 0!");
        }
        Saldo += valor;
        Console.WriteLine($"Seu saldo agora é de: [{Saldo}] ");
    }
    public virtual void Sacar()
    {
        Console.WriteLine($"Seu saldo atual é de: [{Saldo}]!");
        Console.WriteLine("O quanto desejas sacar de sua conta?");
        int saque;
        while (!int.TryParse(Console.ReadLine(), out saque) || saque > Saldo || saque <= 0)
        {
            Console.WriteLine("Digite um valor de saldo que você possua!");
        }
        Saldo -= saque;
        Console.WriteLine($"Saque de [{saque}] concluído com sucesso!");
        Console.WriteLine($"Seu saldo agora é de: [{Saldo}]");
    }
 
}
public class ContaCorrente : ContaBancaria
{
    public int Limite { get; set; }

    public ContaCorrente(int saldoInicial, int limite) : base(saldoInicial)
    {
        Limite = limite;
    }

    public override void Sacar()
    {
        Console.WriteLine($"Seu saldo atual é de: [{Saldo}], com limite de [{Limite}]!");
        Console.WriteLine("O quanto desejas sacar?");
        int saque;
        while (!int.TryParse(Console.ReadLine(), out saque) || saque > (Saldo + Limite) || saque <= 0)
        {
            Console.WriteLine("Digite um valor dentro do seu saldo + limite!");
        }
        Saldo -= saque;
        Console.WriteLine($"Saque de [{saque}] realizado. Novo saldo: [{Saldo}]");
    }
}
public class ContaPoupanca : ContaBancaria
{
    public ContaPoupanca(int saldoInicial) : base(saldoInicial) {}

    public override void Sacar()
    {
        Console.WriteLine($"Seu saldo atual é de: [{Saldo}]!");
        Console.WriteLine("O quanto desejas sacar?");
        int saque;
        while (!int.TryParse(Console.ReadLine(), out saque) || saque > Saldo || saque <= 0)
        {
            Console.WriteLine("Você só pode sacar até o valor do saldo!");
        }
        Saldo -= saque;
        Console.WriteLine($"Saque de [{saque}] concluído. Saldo atual: [{Saldo}]");
    }
}
