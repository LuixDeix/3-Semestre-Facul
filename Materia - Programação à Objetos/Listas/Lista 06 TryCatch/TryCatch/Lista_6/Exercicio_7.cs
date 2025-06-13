using Models.Aluno;

namespace Exercicio_7
{
    public class SistemaAlunoJson
    {
        private string caminhoArquivo;
        public SistemaAlunoJson(string caminhoArquivo)
        {
            this.caminhoArquivo = caminhoArquivo;
        }
        public void GravarAlunos(List<Aluno> alunos)
        {
            try
            {
                string json = JsonSerializer.Serialize(alunos);
                File.WriteAllText(caminhoArquivo, json);
                Console.WriteLine("   • Alunos gravados com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"! Erro ao gravar alunos: {ex.Message} !");
            }
        }
        public List<Aluno> LerAlunos()
        {
            try
            {
                if (!File.Exists(caminhoArquivo))
                {
                    Console.WriteLine("! Arquivo não encontrado. !");
                    return new List<Aluno>();
                }
                string json = File.ReadAllText(caminhoArquivo);
                return JsonSerializer.Deserialize<List<Aluno>>(json) ?? new List<Aluno>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"! Erro ao ler alunos: {ex.Message} !");
                return new List<Aluno>();
            }
        }
    }
}