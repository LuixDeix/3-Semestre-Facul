namespace models;

public class Aluno : Pessoa
{
    private int Matricula;

    public Aluno(int matricula, string? nome, int idade) : base(nome ?? "0", idade)
    {
        this.Matricula = matricula;
    }
    public void Estudar()
    {
        Console.WriteLine("Estou estudando........");
    }
}