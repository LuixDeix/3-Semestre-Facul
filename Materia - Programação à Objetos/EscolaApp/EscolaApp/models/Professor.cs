namespace models;

public class Professor : Pessoa
{
    private string Diciplina;

    public Professor(string nome, int idade, string diciplina) : base(nome, idade)
    {
        this.Diciplina = diciplina;
    }

    public void Ensinar()
    {
        Console.WriteLine("Estou ensinando");
    }

    public override void ExibirInfo()
    {
        Console.WriteLine($"Nome: {this.Nome}\t\tIdade: {this.Idade}\t\tDiciplina: {this.Diciplina}");
    } 
}