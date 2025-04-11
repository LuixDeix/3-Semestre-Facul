namespace Classes;

public class InstrumentoMusical
{
    public string? Nome { get; set; }
    public string? Tipo { get; set; }

    public InstrumentoMusical(string? nome, string? tipo)
    {
        Nome = nome;
        Tipo = tipo;
    }

    public virtual void Tocar()
    {
        Console.WriteLine("Assubiou é??");
    }
}

public class Guitarra : InstrumentoMusical
{
    public Guitarra(string? nome, string? tipo) : base(nome, tipo)
    { 
    }

    public override void Tocar()
    {
        Console.WriteLine("FAZ O SAMPLEY DE GUITARRA! tueu tueu tueue tueu");
    }
}
public class Piano : InstrumentoMusical
{
    public Piano(string? nome, string? tipo) : base(nome, tipo)
    { 
    }

    public override void Tocar()
    {
        Console.WriteLine("Novo Pianista tocando lindamente.....");
    }
}
