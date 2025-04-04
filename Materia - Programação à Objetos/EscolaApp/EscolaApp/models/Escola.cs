namespace models;

public class Escola 
{
    private string Nome;
    private string Endereco;
    private List<Turma> Turmas = new List<Turma>();
    private Diretoria Diretoria;
    public Escola(
        string nome, 
        string endereco, 
        Diretoria diretor) 
    {
            this.Nome = nome;
            this.Endereco = endereco;
            this.Diretoria = diretor;
    }

    public void ListarTurma()
    {
        Console.WriteLine($"Turma: {this.Nome}");
        foreach (Turma turma in this.Turmas)
        {
            Console.WriteLine(turma.getNome());
        }
    }

    public void ExibirInfo()
    {
        Console.WriteLine(this.Nome);
        Console.WriteLine(this.Endereco);
    }

}