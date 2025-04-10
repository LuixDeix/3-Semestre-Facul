using Classes;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Escolha sua Opção:");
        Console.WriteLine("1 - Adicionar nova Pessoa");
        Console.WriteLine("2 - Adicionar novo Carro");
        Console.WriteLine("3 - Ligar o Carro");
        Console.WriteLine("4 - Idade da Pessoa em Meses");
        Console.WriteLine("5 - Conta Bancária = Depósito");
        Console.WriteLine("6 - Conta Bancária = Saque");
        Console.WriteLine("7 - Adicionar novo Livro");

        if (int.TryParse(Console.ReadLine(), out int opcao))
        {
            switch (opcao)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Digite o Nome da pessoa:");
                    string? nome = Console.ReadLine();

                    Console.WriteLine("Digite a Idade da pessoa:");
                    if (!int.TryParse(Console.ReadLine(), out int idade1))
                    {
                        Console.WriteLine("Idade inválida. Usando idade 0.");
                        idade1 = 0;
                    }

                    Pessoa pessoa1 = new Pessoa { Nome = nome, Idade = idade1 };
                    pessoa1.MensagemPersonalizada();
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Digite a marca do carro:");
                    string? marca = Console.ReadLine();

                    Console.WriteLine("Digite o modelo:");
                    string? modelo = Console.ReadLine();

                    Console.WriteLine("Digite o ano:");
                    if (!int.TryParse(Console.ReadLine(), out int ano))
                    {
                        Console.WriteLine("Ano inválido. Usando 0.");
                        ano = 0;
                    }

                    Carro carroCriado = new Carro(marca ?? "", modelo ?? "", ano);
                    Console.WriteLine("Carro criado com sucesso!");
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("Ligando o carro:");
                    Carro carro = new Carro("Chevrolet", "Onix", 2020);
                    carro.Ligar();
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("Digite seu nome:");
                    string? nomePessoa = Console.ReadLine();

                    Console.WriteLine("Digite sua idade:");
                    if (!int.TryParse(Console.ReadLine(), out int idade2))
                    {
                        Console.WriteLine("Idade inválida. Usando idade 0.");
                        idade2 = 0;
                    }

                    Pessoa pessoa2 = new Pessoa(nomePessoa ?? "", idade2);
                    pessoa2.IdadeEmMeses();
                    break;

                case 5:
                    Console.Clear();
                    ContaBancaria contaDep = new ContaBancaria(100);
                    contaDep.Depositar();
                    break;

                case 6:
                    Console.Clear();
                    ContaBancaria contaSaq = new ContaBancaria(200);
                    contaSaq.Sacar();
                    break;

                case 7:
                    Console.Clear();
                    Console.WriteLine("Digite o título do livro:");
                    string? titulo = Console.ReadLine();

                    Console.WriteLine("Digite o autor:");
                    string? autor = Console.ReadLine();

                    Console.WriteLine("Digite o ano de publicação:");
                    if (!int.TryParse(Console.ReadLine(), out int anoLivro))
                    {
                        Console.WriteLine("Ano inválido. Usando 0.");
                        anoLivro = 0;
                    }

                    Livro livro = new Livro(titulo ?? "", autor ?? "", anoLivro);
                    livro.ExibirDadosLivro();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida!");
        }
    }
}
