namespace Classes;

public class Temperatura
{
    public string? TipoTemperatura { get; }
    public int Graus { get; }

    public Temperatura(string? tipotemperatura, int graus)
    {
        TipoTemperatura = tipotemperatura?.ToLower();
        Graus = graus;
    }

    public void MostrarConversao()
    {
        if (TipoTemperatura == "celsius")
        {
            Console.WriteLine($"{Graus}°C equivalem a {CalcularFahrenheit()}°F");
        }
        else if (TipoTemperatura == "fahrenheit")
        {
            Console.WriteLine($"{Graus}°F equivalem a {CalcularCelsius()}°C");
        }
        else
        {
            Console.WriteLine("Tipo de temperatura inválido. Use 'celsius' ou 'fahrenheit'.");
        }
    }

    private int CalcularFahrenheit()
    {
        return (Graus * 9 / 5) + 32;
    }

    private int CalcularCelsius()
    {
        return (Graus - 32) * 5 / 9;
    }
}
