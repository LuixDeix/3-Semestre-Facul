// Interface IImprimivel
public interface IImprimivel
{
    void Imprimir();
}

// Classe Relatorio implementando IImprimivel
public class Relatorio : IImprimivel
{
    public string Titulo { get; set; }
    public string Conteudo { get; set; }

    public void Imprimir()
    {
        Console.WriteLine("=== RELATÓRIO ===");
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Conteúdo: {Conteudo}");
        Console.WriteLine("=================\n");
    }
}

// Classe Contrato implementando IImprimivel
public class Contrato : IImprimivel
{
    public string NomeParte1 { get; set; }
    public string NomeParte2 { get; set; }

    public void Imprimir()
    {
        Console.WriteLine("=== CONTRATO ===");
        Console.WriteLine($"Parte 1: {NomeParte1}");
        Console.WriteLine($"Parte 2: {NomeParte2}");
        Console.WriteLine("================\n");
    }
}
