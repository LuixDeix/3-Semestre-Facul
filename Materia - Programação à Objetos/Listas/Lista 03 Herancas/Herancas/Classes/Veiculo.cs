namespace Classes;

public class Veiculo
{
    public string? Motor { get; set; }
    public string? Rodas { get; set; }

    public Veiculo(string? motor, string? rodas)
    {
        Motor = motor;
        Rodas = rodas;
    }

    public void LigarVeiculo()
    {
        Console.WriteLine("O veículo está ligadado!");
    }
}

public class Carro : Veiculo
{
    public Carro(string? motor, string? rodas) : base(motor, rodas)
    {
    }
    public void Dirigir()
    {
        Console.WriteLine("Pai ta de Carro!");
    }
}

public class Moto : Veiculo
{
    public Moto(string? motor, string? rodas) : base(motor, rodas)
    {
    }
    public void Empinar()
    {
        Console.WriteLine("Vai cair viu!");
    }
}