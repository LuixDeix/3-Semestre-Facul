namespace Exercicio_5
{
    public class EscreverTXT
    {
        public void WriteTXT(string filepath)
        {
            try
            {
                Console.WriteLine("   • Digitie o texto: ");

                string? texto = Console.ReadLine(); 
                File.WriteAllText(filepath, texto); 

                Console.WriteLine("   • Texto escrito com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($" ! Erro ao escrever no arquivo: {ex.Message} !");
            }
        }
    }
}