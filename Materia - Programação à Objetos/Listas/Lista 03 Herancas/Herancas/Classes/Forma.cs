namespace Classes;

public class Forma
{
    public double Bases {get; set;}
    public double Altura {get; set;}

    public Forma(double bases, double altura)
    {
        Bases = bases;
        Altura = altura;
    }
    public virtual void CalcularArea()
    {
        Console.WriteLine($"A area da sua forma é de {Bases * Altura}");
    }
}

public class Quadrado : Forma
{
    public Quadrado(double bases, double altura) : base(bases,altura)
    {
    }
    public override void CalcularArea()
    {
        Console.WriteLine($"A area da sua forma é de {Bases * Altura}");
    }
}
public class Triangulo : Forma
{
    public Triangulo(double bases, double altura) : base(bases,altura)
    {
    }
    public override void CalcularArea()
    {
        Console.WriteLine($"A area da sua forma é de {Bases * Altura / 2.0}");
    }
}