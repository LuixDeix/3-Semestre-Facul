using Classes;

internal class Program
{
    private static void Main(string[] args)
    {
        int opcao;

        do
        {
            Console.Clear();
            Console.WriteLine("====== MENU PRINCIPAL ======");
            Console.WriteLine("1 - Funcionário");
            Console.WriteLine("2 - Animal");
            Console.WriteLine("3 - Conta Bancária");
            Console.WriteLine("4 - Eletrônico");
            Console.WriteLine("5 - Forma Geométrica");
            Console.WriteLine("6 - Instrumento Musical");
            Console.WriteLine("7 - Mídia");
            Console.WriteLine("8 - Veículo");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
        } while (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 0 || opcao > 8);

        switch (opcao)
        {
            case 1:
                MenuFuncionario();
                break;
            case 2:
                MenuAnimal();
                break;
            case 3:
                MenuContaBancaria();
                break;
            case 4:
                MenuEletronico();
                break;
            case 5:
                MenuForma();
                break;
            case 6:
                MenuInstrumento();
                break;
            case 7:
                MenuMidia();
                break;
            case 8:
                MenuVeiculo();
                break;
            case 0:
                Console.WriteLine("Encerrando...");
                break;
        }
    }

    static void MenuFuncionario()
    {
        Console.WriteLine("Deseja criar um Gerente ou Desenvolvedor?");
        string tipo = Console.ReadLine() ?? "0";
        Console.Write("Nome: ");
        string? nome = Console.ReadLine();
        Console.Write("Salário: ");
        double salario = Convert.ToDouble(Console.ReadLine());

        if (tipo == "gerente")
        {
            var gerente = new Gerente(nome, salario);
            gerente.ExibirDados();
            gerente.BeneficioSalarial();
        }
        else if (tipo == "desenvolvedor")
        {
            var dev = new Desenvolvedor(nome, salario);
            dev.ExibirDados();
            dev.BeneficioSalarial();
        }
    }

    static void MenuAnimal()
    {
        Console.WriteLine("Deseja criar um Cachorro ou Gato?");
        string tipo = Console.ReadLine() ?? "0";
        Console.Write("Nome: ");
        string? nome = Console.ReadLine();
        Console.Write("Idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        if (tipo == "cachorro")
        {
            var dog = new Cachorro(nome, idade);
            dog.Comer();
            dog.EmitirSom();
        }
        else if (tipo == "gato")
        {
            var cat = new Gato(nome, idade);
            cat.Comer();
            cat.EmitirSom();
        }
    }

    static void MenuContaBancaria()
    {
        Console.WriteLine("Conta Corrente ou Conta Poupança?");
        string tipo = Console.ReadLine() ?? "0";
        Console.Write("Saldo Inicial: ");
        int saldo = Convert.ToInt32(Console.ReadLine());

        if (tipo == "corrente")
        {
            Console.Write("Limite: ");
            int limite = Convert.ToInt32(Console.ReadLine());
            var cc = new ContaCorrente(saldo, limite);
            cc.Depositar();
            cc.Sacar();
        }
        else if (tipo == "poupanca")
        {
            var cp = new ContaPoupanca(saldo);
            cp.Depositar();
            cp.Sacar();
        }
    }

    static void MenuEletronico()
    {
        Console.WriteLine("Smartphone ou Notebook?");
        string tipo = Console.ReadLine() ?? "0";
        Console.Write("Dono: ");
        string? dono = Console.ReadLine();

        if (tipo == "smartphone")
        {
            var s = new Smartphone(dono, tipo);
            s.Ligar();
        }
        else if (tipo == "notebook")
        {
            var n = new Notebook(dono, tipo);
            n.Ligar();
        }
    }

    static void MenuForma()
    {
        Console.WriteLine("Quadrado ou Triângulo?");
        string tipo = Console.ReadLine() ?? "0";
        Console.Write("Base: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Altura: ");
        double h = Convert.ToDouble(Console.ReadLine());

        if (tipo == "quadrado")
        {
            var q = new Quadrado(b, h);
            q.CalcularArea();
        }
        else if (tipo == "triangulo")
        {
            var t = new Triangulo(b, h);
            t.CalcularArea();
        }
    }

    static void MenuInstrumento()
    {
        Console.WriteLine("Guitarra ou Piano?");
        string tipo = Console.ReadLine() ?? "0";
        Console.Write("Nome: ");
        string? nome = Console.ReadLine();

        if (tipo == "guitarra")
        {
            var g = new Guitarra(nome, tipo);
            g.Tocar();
        }
        else if (tipo == "piano")
        {
            var p = new Piano(nome, tipo);
            p.Tocar();
        }
    }

    static void MenuMidia()
    {
        Console.WriteLine("CD ou DVD?");
        string tipo = Console.ReadLine() ?? "0";
        Console.Write("Nome: ");
        string? nome = Console.ReadLine();
        Console.Write("Tipo: ");
        string? tipoMidia = Console.ReadLine();
        Console.Write("Filme: ");
        string? filme = Console.ReadLine();
        Console.Write("Áudio: ");
        string? audio = Console.ReadLine();

        if (tipo == "cd")
        {
            var cd = new CD(nome, tipoMidia, filme, audio);
            cd.ExibirDetalhes();
        }
        else if (tipo == "dvd")
        {
            var dvd = new DVD(nome, tipoMidia, filme, audio);
            dvd.ExibirDetalhes();
        }
    }

    static void MenuVeiculo()
    {
        Console.WriteLine("Carro ou Moto?");
        string tipo = Console.ReadLine() ?? "0";
        Console.Write("Motor: ");
        string? motor = Console.ReadLine();
        Console.Write("Rodas: ");
        string? rodas = Console.ReadLine();

        if (tipo == "carro")
        {
            var c = new Carro(motor, rodas);
            c.LigarVeiculo();
            c.Dirigir();
        }
        else if (tipo == "moto")
        {
            var m = new Moto(motor, rodas);
            m.LigarVeiculo();
            m.Empinar();
        }
    }
}
