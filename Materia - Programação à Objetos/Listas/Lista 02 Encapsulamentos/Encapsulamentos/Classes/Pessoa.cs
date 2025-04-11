namespace Classes;

public class Pessoa
{
    private string? Nome { get; set; }
    private int Idade { get; set; }

    public Pessoa() { }
    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
    public void MensagemPersonalizada()
    {
        Console.WriteLine($"Então você tem {Idade} anos {Nome}?");
    }
    public void IdadeEmMeses()
    {
        Console.WriteLine($"Você tem {Idade * 12} mêses de idade!");
    }
    public int IdadeEmDias
    {
        get
        {
            return Idade * 365;
        }
    }
}