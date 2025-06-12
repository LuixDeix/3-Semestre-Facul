namespace Exercicio_9
{
    public class Aluno
    {
        public string Nome { get; set; }
        public double Nota { get; set; }

        public Aluno(string nome, double nota)
        {
            Nome = nome;
            Nota = nota;
        }
        static void Main()
        {
            List<Aluno> alunos = new List<Aluno>
        {
            new Aluno("Jenifer", 5.2),
            new Aluno("Luis", 2.2),
            new Aluno("Dudarts", 9.9),
        };
            var aprovados = alunos.Where(a => a.Nota > 7);

            Console.WriteLine("|___Alunos Com Nota > 7:__| ");
            foreach (var aluno in aprovados)
            {
                Console.WriteLine($"Nome: {aluno.Nome} - Nota: {aluno.Nota}");
            }
            Console.WriteLine("|_________________________| ");
            Console.WriteLine("|=========================| ");
        }
    }
}