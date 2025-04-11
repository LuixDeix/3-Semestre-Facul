using System.Reflection;

namespace Classes;

public class Animal
{
    public string? Nome { get; set; }
    public int Idade { get; set; }

    public Animal(string? nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
    public void Comer()
    {
        Console.WriteLine("O animal está comendo......");
    }
}

public class Cachorro : Animal
{
    public Cachorro(string? nome, int idade) : base(nome, idade)
    {
    }
    public void EmitirSom()
    {
        Console.WriteLine("Au au au au au..");
    }
}

public class Gato : Animal
{
    public Gato(string? nome, int idade) : base(nome, idade)
    {
    }
    public void EmitirSom()
    {
        Console.WriteLine("Miauu Miauu Miauu");
    }
}