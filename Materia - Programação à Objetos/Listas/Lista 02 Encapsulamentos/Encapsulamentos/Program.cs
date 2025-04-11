using Classes;
using Models;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Escolha sua Opção:");
        Console.WriteLine("1 - Adicionar Nova Pessoa");
        Console.WriteLine("2 - Adicionar novo Produto");
        Console.WriteLine("3 - Nova ContaBancaria");
        Console.WriteLine("4 - Mostrar idade em Dias");
        Console.WriteLine("5 - Novo Retangulo");
        Console.WriteLine("6 - Novo Funcionario / Salario Liquido");
        Console.WriteLine("7 - Calculo da média");
        Console.WriteLine("8 - Calculo de Circulo");
        Console.WriteLine("9 - Conversão de Temperatura");
        Console.WriteLine("10 - Cadastrar novo usuario");

        if (int.TryParse(Console.ReadLine(), out int opcao))
        {
            switch (opcao)
            {
                case 1:
                    Console.Clear();
                    var pessoa = new Pessoa("João", 25);
                    pessoa.MensagemPersonalizada();
                    pessoa.IdadeEmMeses();
                    Console.WriteLine($"Idade em dias: {pessoa.IdadeEmDias}");
                    break;

                case 2:
                    Console.Clear();
                    var produto = new Produto { Nome = "Celular", preco = 1500.99f, estoque = 10 };
                    Console.WriteLine($"Produto: {produto.Nome}, Preço: R${produto.preco}, Estoque: {produto.estoque}");
                    break;

                case 3:
                    Console.Clear();
                    var conta = new ContaBancaria(100);
                    conta.Depositar();
                    conta.Sacar();
                    break;

                case 4:
                    Console.Clear();
                    var pessoaIdade = new Pessoa("Maria", 30);
                    Console.WriteLine($"Idade em dias: {pessoaIdade.IdadeEmDias}");
                    break;

                case 5:
                    Console.Clear();
                    var ret = new Retangulo(5, 10);
                    Console.WriteLine($"Área do retângulo: {ret.CalcularArea()}");
                    break;

                case 6:
                    Console.Clear();
                    var func = new Funcionario("Carlos", 3000, 500);
                    Console.WriteLine($"Salário líquido: R${func.CalcularSalarioLiquido()}");
                    break;

                case 7:
                    Console.Clear();
                    var aluno = new Aluno(7, 9);
                    Console.WriteLine($"Média do aluno: {aluno.CalcularMédiaAluno()}");
                    break;

                case 8:
                    Console.Clear();
                    var circulo = new Circulo(4);
                    Console.WriteLine($"Área do círculo: {circulo.CalcularAreaCirculo()}");
                    break;

                case 9:
                    Console.Clear();
                    var temp = new Temperatura("celsius", 25);
                    temp.MostrarConversao();
                    break;

                case 10:
                    Console.Clear();
                    CadastrarUsuario();
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

    static void CadastrarUsuario()
    {
        Console.WriteLine("Digite um nome de usuário: ");
        string nomeUsuario = Console.ReadLine() ?? "0";

        Console.WriteLine("Digite sua senha: ");
        string senhaUsuario = Console.ReadLine() ?? "0";

        try
        {
            CadastroDeUsuario usuario = new CadastroDeUsuario(nomeUsuario, senhaUsuario);
            Console.WriteLine("Usuário cadastrado com sucesso!");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro ao cadastrar usuário: {ex.Message}");
        }
    }
}
