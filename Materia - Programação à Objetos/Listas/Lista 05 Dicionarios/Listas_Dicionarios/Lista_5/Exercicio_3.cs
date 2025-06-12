namespace Exercicio_3
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public void Printar()
        {
            Console.WriteLine($"Nome do Produto: {Nome,-10} - Valor: R${Preco:F2}");
        }

        // -=-=-=-=-=-=-=-=-=-=-=-=-=-=-

        static void Main()
        {
            List<Produto> produtos = new List<Produto>
            {
                new Produto("Café", 350.0),
                new Produto("RTX", 3000.0),
                new Produto("Bala de Iogurte", 1.00)
            };
            Console.WriteLine("|__________Lista de Produtos:_________| ");
            foreach (var produto in produtos)
            {
                produto.Printar();
            }
            Console.WriteLine("|_____________________________________| ");
            Console.WriteLine("|=====================================| ");
        }
    }
}
