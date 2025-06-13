namespace Exercicio_4
{
    public class ExibirTXT
    {
        public LerTXT(string filepath)
        {
            try
            {
                if (file.Exists(filepath))
                {
                    string corpo = file.ReadAllText(filepath);
                    Console.WriteLine($"Conteúdo do arquivo: {corpo}");
                }
                else
                {
                    Console.WriteLine("Arquivo não encontrado.");
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao ler o arquivo: {ex.Message}");
            }
        }
    }
}