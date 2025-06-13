namespace Exercicio_6
{
    public class Logger
    {
        private string logPath;

        public Logger(string logPath)
        {
            this.logPath = logPath;
        }
        public void RegistrarErro(string mensagem)
        {
            try
            {
                string logMsg = $"! ERRO: {mensagem}{Environment.NewLine} !";
                File.AppendAllText(logPath, logMsg);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"! Falha ao registrar log: {ex.Message} !");
            }
        }
    }
}