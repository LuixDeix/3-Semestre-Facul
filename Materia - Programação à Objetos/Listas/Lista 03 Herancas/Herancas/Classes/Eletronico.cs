namespace Classes;

public class Eletronico
{
    public string? Dono { get; set; }
    public string? Tipo { get; set; }

    public Eletronico(string? dono, string? tipo)
    {
        Dono = dono;
        Tipo = tipo;
    }

    public virtual void Ligar()
    {
        Console.WriteLine("Ligando o seu dispositivo.....");
    }
}

public class Smartphone : Eletronico
{
    public Smartphone(string? dono, string? tipo) : base(dono, tipo)
    {
    }

    public override void Ligar()
    {
        Console.WriteLine("Ligando o seu Smartphone");
    }
}
public class Notebook : Eletronico
{
    public Notebook(string? dono, string? tipo) : base(dono, tipo)
    {
    }

    public override void Ligar()
    {
        Console.WriteLine("Ligando o seu Notebook");
    }
}
