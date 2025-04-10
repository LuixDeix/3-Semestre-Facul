namespace Classes;

public class Livro
{
    public string? Titulo;
    public string? Autor;
    public int Ano;
    public Livro(string titulo, string autor, int ano) 
    {
        Titulo = titulo;
        Autor = autor;
        Ano = ano;
    }
    public void ExibirDadosLivro() 
    {
        Console.WriteLine($"O livro '{Titulo}' foi escrito por {Autor} no ano de {Ano}!");
    }
}