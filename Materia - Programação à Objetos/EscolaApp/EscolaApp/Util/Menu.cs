namespace Util;
public class Menu
{
    public static void exibir()
    {
        Console.WriteLine("Escolha uma opção");
        Console.WriteLine("1 - Cadastrar professor");
    }

    public static int escolherOpcao()
    {
        string? opcao = Console.ReadLine();
        return int.Parse(opcao ?? "0");
    }
}