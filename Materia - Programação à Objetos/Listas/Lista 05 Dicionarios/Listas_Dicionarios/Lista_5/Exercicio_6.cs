namespace Exercicio_6
{
    public class BuscaCliente
    {
        public string Nome { get; set; }
        public string RA { get; set; }

        public BuscaCliente(string nome, string ra)
        {
            Nome = nome;
            RA = ra;
        }

        public void Printar()
        {
            Console.WriteLine($" | Nome: {Nome,-10} | RA: {RA}");
        }

        // -=-=-=-=-=-=-=-=-=-=-=-=-=-=-
        static void Main()
        {
            Dictionary<string, BuscaCliente> clientes = new Dictionary<string, BuscaCliente>();

            clientes.Add("203463", new BuscaCliente("Jenifer", "203463"));
            clientes.Add("209673", new BuscaCliente("Luis", "209673"));
            clientes.Add("000000", new BuscaCliente("Dudarts", "000000"));

            Console.WriteLine(" |________Clientes Cadastrados:________| ");
            foreach (var entrada in clientes)
            {
                entrada.Value.Printar();
            }
            Console.WriteLine(" |_____________________________________| ");
            Console.WriteLine(" |=====================================| ");
            Console.WriteLine("   • Digite um RA para buscar o cliente:");

            string? busca_ra = Console.ReadLine();
            if (clientes.TryGetValue(busca_ra, out BuscaCliente clienteEncontrado))
            {
                Console.WriteLine(" Cliente encontrado: ");
                Console.WriteLine(" |_________Cliente Enconrtado:_________| ");
                clienteEncontrado.Printar();
                Console.WriteLine(" |_____________________________________| ");
                Console.WriteLine(" |=====================================| ");
            }
            else
            {
                Console.WriteLine("! Cliente não encontrado. !");
            }
        }
    }
}