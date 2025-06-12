namespace Exercicio_10
{
    public class BuscaDeProduto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public BuscaDeProduto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
        static void Main()
        {
            List<BuscaDeProduto> produtos = new List<BuscaDeProduto>
        {
            new BuscaDeProduto("Café", 350.0),
            new BuscaDeProduto("RTX", 3000.0),
            new BuscaDeProduto("Bala de Iogurte", 1.00)
        };

            Console.Write("   • Digite o nome do produto: ");
            string? nomeBusca = Console.ReadLine();

            var resultado = produtos.FirstOrDefault(p =>
                p.Nome.Equals(nomeBusca, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("|___________________________________| ");
            if (resultado != null)
            {
                Console.WriteLine($"| Produto encontrado: {resultado.Nome,-10} - R${resultado.Preco:F2}");
                Console.WriteLine("|___________________________________| ");
            }
            else
            {
                Console.WriteLine("! Produto não encontrado. !");
            }
        }
    }
}