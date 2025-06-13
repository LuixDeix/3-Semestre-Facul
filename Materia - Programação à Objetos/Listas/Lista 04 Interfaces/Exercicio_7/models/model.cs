// Interface IJogador
public interface IJogador
{
    void Atacar();
}

// Classe Mago implementando IJogador
public class Mago : IJogador
{
    public string Nome { get; set; }

    public void Atacar()
    {
        Console.WriteLine($"{Nome} lança uma bola de fogo!");
    }
}

// Classe Guerreiro implementando IJogador
public class Guerreiro : IJogador
{
    public string Nome { get; set; }

    public void Atacar()
    {
        Console.WriteLine($"{Nome} golpeia com sua espada!");
    }
}
