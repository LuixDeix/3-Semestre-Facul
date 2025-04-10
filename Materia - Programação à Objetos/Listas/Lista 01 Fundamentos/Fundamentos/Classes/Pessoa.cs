namespace Classes;

public class Pessoa 
{
    public string? Nome;
    public int Idade;

    public Pessoa(){}
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
}