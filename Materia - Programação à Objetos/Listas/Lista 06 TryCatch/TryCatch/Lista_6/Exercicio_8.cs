using Models.Produtos;

namespace Exercicio_8
{
    public class SistemaProdutoCSV : Produto
    {
        private string caminhoArquivo;

        public SistemaProdutoCSV(string caminhoArquivo)
        {
            this.caminhoArquivo = caminhoArquivo;
        }
        public void GravarProdutos(List<Produto> produtos)
        {
            try
            {
                using (var writer = new StreamWriter(caminhoArquivo, false))
                {
                    writer.WriteLine("   • Digite o Nome,Preco,Quantidade");
                    foreach (var produto in produtos)
                    {
                        writer.WriteLine($"{produto.Nome},{produto.Preco},{produto.Quantidade}");
                    }
                }
                Console.WriteLine("   • Produtos gravados com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"! Erro ao gravar produtos: {ex.Message} !");
            }
        }
        public List<Produto> LerProdutos()
        {
            var produtos = new List<Produto>();
            try
            {
                if (!File.Exists(caminhoArquivo))
                {
                    Console.WriteLine(" ! Arquivo não encontrado. !");
                    return produtos;
                }
                using (var reader = new StreamReader(caminhoArquivo))
                {
                    string linha;
                    bool primeiraLinha = true;
                    while ((linha = reader.ReadLine()) != null)
                    {
                        if (primeiraLinha)
                        {
                            primeiraLinha = false;
                            continue;
                        }
                        var partes = linha.Split(',');
                        if (partes.Length == 3)
                        {
                            produtos.Add(new Produto
                            {
                                Nome = partes[0],
                                Preco = decimal.TryParse(partes[1], out var preco) ? preco : 0,
                                Quantidade = int.TryParse(partes[2], out var qtd) ? qtd : 0
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"! Erro ao ler produtos: {ex.Message} !");
            }
            return produtos;
        }
    }
}