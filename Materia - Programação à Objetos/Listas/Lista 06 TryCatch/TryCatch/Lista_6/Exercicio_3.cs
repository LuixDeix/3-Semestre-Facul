namespace Exercicio_3
{
    public class ArquivoExistente
    {
        public ArquivoExistente(string filepath)
        {
            try
            {
                FileInfo arquivo = new FileInfo(filepath); 
                using (var abrir = arquivo.Open(FileMode.Open)) 
                {
                    Console.WriteLine("   • Arquivo aberto com sucesso!");
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine(" ! Arquivo inexistente. !");
            }
        }
    }
}