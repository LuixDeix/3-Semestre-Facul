namespace Classes;

public class Midia
{
    public string? Nome { get; set; }
    public string? Tipo { get; set; }
    public string? Filme { get; set; }
    public string? Audio { get; set; }

    public Midia(string? nome, string? tipo, string? filme, string? audio)
    {
        Nome = nome;
        Tipo = tipo;
        Filme = filme;
        Audio = audio;
    }

    public virtual void ExibirDetalhes()
    {
        Console.WriteLine($"Nome = {Nome}");
        Console.WriteLine($"Tipo = {Tipo}");
        Console.WriteLine($"Filme = {Filme}");
        Console.WriteLine($"Audio = {Audio}");
    }
}

public class CD : Midia
{
    public CD(string? nome, string? tipo, string? filme, string? audio) : base(nome, tipo, filme, audio)
    { 
    }

    public override void ExibirDetalhes()
    {
        Console.WriteLine($"Nome = {Nome}");
        Console.WriteLine($"Tipo = {Tipo}");
        Console.WriteLine($"Audio = {Audio}");
    }
}
public class DVD : Midia
{
    public DVD(string? nome, string? tipo, string? filme, string? audio) : base(nome, tipo, filme, audio)
    { 
    }

    public override void ExibirDetalhes()
    {
        Console.WriteLine($"Nome = {Nome}");
        Console.WriteLine($"Tipo = {Tipo}");
        Console.WriteLine($"Filme = {Filme}");
        Console.WriteLine($"Audio = {Audio}");
    }
}
