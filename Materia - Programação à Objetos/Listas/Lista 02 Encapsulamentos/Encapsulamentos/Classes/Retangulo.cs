namespace Classes;

public class Retangulo
{
    public int Largura { get; }
    public int Altura { get; }

    public Retangulo(int largura, int altura)
    {
        Largura = largura;
        Altura = altura;
    }
    public int CalcularArea()
    {
        return Largura * Altura;
    }
}