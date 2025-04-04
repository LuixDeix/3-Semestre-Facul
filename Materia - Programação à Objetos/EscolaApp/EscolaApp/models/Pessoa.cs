namespace models;

public class Pessoa
{
    private string Nome;
    private int Idade;

    public Pessoa(string nome, int idade)
    {
        this.Nome = nome;
        this.Idade = idade;
    }

    public virtual void ExibirInfo()
    {
        Console.WriteLine($"Nome: {this.Nome}\t\tIdade: {this.Idade}");
    }

}