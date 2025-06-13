namespace Exercicio_9
{
    public class TryFinallyArquivo
    {
        public void AbrirArquivo(string caminhoArquivo)
        {
            FileStream arquivo = null;
            try
            {
                arquivo = new FileStream(caminhoArquivo, FileMode.Open);
                Console.WriteLine("   • Arquivo aberto com sucesso!");
            }
            finally
            {
                if (arquivo != null)
                {
                    arquivo.Close();
                    Console.WriteLine("! Arquivo fechado. !");
                }
            }
        }
    }
}