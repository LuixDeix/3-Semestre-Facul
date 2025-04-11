namespace Classes;

public class Circulo
{
    public double Raio { get; }

    public Circulo(double raio)
    {
        Raio = raio;
    }

    public double CalcularAreaCirculo()
    {
        return 3.14 * Raio * Raio;
    }
}
