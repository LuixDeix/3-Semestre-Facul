using System;
using System.Collections.Generic;
using System.Xml;

class Program
{
    public static void Somatorio() //-=-=-=-=-=-=-=-=- Somatório -=-=-=-=-=-=-=-=-
    {
        int soma_total = 0;
        Console.WriteLine("Defina o número inicial: ");
        int numero = Int32.Parse(Console.ReadLine() ?? "0");
        while (numero <= 0)
        {
            Console.WriteLine("Erro no valor selecionado, número tem que ser maior que ZERO!");
            Console.WriteLine("Digite Novamente: ");
            numero = Int32.Parse(Console.ReadLine() ?? "0");
        }

        Console.Write("Somatório: ");
        for (int i = 1; i <= numero; i++)
        {
            soma_total += i;
            Console.Write(i);

            if (i < numero) Console.Write(" + ");
        }

        Console.WriteLine($" = {soma_total}");
    }

    public static int Relogio() //-=-=-=-=-=-=-=-=- Relógio -=-=-=-=-=-=-=-=-
    {
        Console.WriteLine("Defina as Horas: ");
        int horas = Int32.Parse(Console.ReadLine() ?? "0");
        while (horas < -1 || horas > 23)
        {
            Console.WriteLine("Erro Em Horas");
            horas = Int32.Parse(Console.ReadLine() ?? "0");
        }

        Console.WriteLine("Defina os Minutos: ");
        int minutos = Int32.Parse(Console.ReadLine() ?? "0");
        while (minutos < -1 || minutos > 59)
        {
            Console.WriteLine("Erro Em Minutos");
            minutos = Int32.Parse(Console.ReadLine() ?? "0");
        }

        Console.WriteLine("Defina os Segundos: ");
        int segundos = Int32.Parse(Console.ReadLine() ?? "0");
        while (segundos < -1 || segundos > 59)
        {
            Console.WriteLine("Errou Em Segundos");
            segundos = Int32.Parse(Console.ReadLine() ?? "0");
        }
        int milisegundos = ((horas * 3600) + (minutos * 60) + segundos) * 1000;
        return milisegundos;
    }
    static bool MelhorQueAMedia(int[] Amigos, int Pontuacao) //-=-=-=-=-=-=-=-=- Média -=-=-=-=-=-=-=-=-
    {
        double media = Amigos.Average();
        return Pontuacao > media;
    }

    public static void Livro_de_notas() //-=-=-=-=-=-=-=-=- Livro de Notas -=-=-=-=-=-=-=-=-
    {
        Console.WriteLine("Insira sua pontuação: (0 a 100)");
        int pontuacao = Int32.Parse(Console.ReadLine() ?? "0");

        if (pontuacao >= 90 && pontuacao <= 100)
        {
            Console.WriteLine("Sua nota final é ( A ), Nerd");
        }
        else if (pontuacao >= 80 && pontuacao < 90)
        {
            Console.WriteLine("Sua nota final é ( B )");
        }
        else if (pontuacao >= 70 && pontuacao < 80)
        {
            Console.WriteLine("Sua nota final é ( C )");
        }
        else if (pontuacao >= 60 && pontuacao < 70)
        {
            Console.WriteLine("Sua nota final é ( D )");
        }
        else
        {
            Console.WriteLine("Sua nota final é ( F ), Que pena meu rei....");
        }

    }
    static void Main() //-=-=-=-=-=-=-=-=- Def Start -=-=-=-=-=-=-=-=-
    {
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1 - Somatório");
        Console.WriteLine("2 - Relógio");
        Console.WriteLine("3 - Média Geral");
        Console.WriteLine("4 - Livro de Notas");
        Console.Write("Opção: ");

        if (int.TryParse(Console.ReadLine(), out int opcao))
        {
            switch (opcao)
            {
                case 1:
                    Somatorio();
                    break;
                case 2:
                    int resultado = Relogio();
                    Console.WriteLine($"Tempo total em milissegundos: {resultado}");
                    break;
                case 3:
                    Console.WriteLine("{ 50, 60, 70, 80, 90 }, 75"); 
                    Console.WriteLine(MelhorQueAMedia(new int[] { 50, 60, 70, 80, 90 }, 75)); 
                    Console.WriteLine("{ 50, 60, 70, 80, 90 }, 60"); 
                    Console.WriteLine(MelhorQueAMedia(new int[] { 50, 60, 70, 80, 90 }, 60)); 
                    break;
                case 4:
                    Livro_de_notas();
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida!");
        }
    }

}
