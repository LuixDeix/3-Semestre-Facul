namespace Util;
using models;

public class BancoDeDados
{
    public List<Professor> Professores = new List<Professor>();
    public List<Aluno> Alunos = new List<Aluno>();

    public void CadastrarProfessor()
    {
        Console.WriteLine("Cadastrar professor");
        Console.WriteLine("Digite o nome do Professor");
        string nome = Console.ReadLine() ?? "0";

        Console.WriteLine("Digite a idade do Professor");
        int idade = int.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Digite a disciplina do Professor");
        string disciplina = Console.ReadLine() ?? "0";

        Professor professor = new Professor(nome, idade, disciplina);
        this.Professores.Add(professor);
    }

    public void CadastrarAluno()
    {
        Console.WriteLine("Cadastrar aluno");
        Console.WriteLine("Digite nome do aluno");
        string nome = Console.ReadLine() ?? "0";

        Console.WriteLine("Digite idade do aluno");
        int idade = int.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Digite matricula do aluno");
        int matricula = int.Parse(Console.ReadLine() ?? "0");

        Aluno aluno = new Aluno(nome, idade, matricula);
        this.Alunos.Add(aluno);
    }

    public void CadastrarDiretor()
    {
        Console.WriteLine("Cadastrar diretor");
        Console.WriteLine("Escolha o professor");
        this.ListarProfessores();
        Console.ReadKey();
    }

    public void ListarProfessores()
    {
        int i = 0;
        foreach (Professor professor in this.Professores)
        {
            Console.Write($"{(i++)} - ");
            professor.ExibirInfo();
        }
    }
}
