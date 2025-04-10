namespace Classes;

public class Carro
{
    public string? Marca;
    public string? Modelo;
    public int Ano;

    public Carro(string marca, string modelo, int ano) 
    {
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
    }
    public void Ligar()
    {
        Console.WriteLine("O carro está ligado");
    }

}