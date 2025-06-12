namespace Exercicio_5
{
    class Navegacao
    {
        static void Quinto_Exercicio()
        {
            Stack<string> historicoNavegacao = new Stack<string>();

            historicoNavegacao.Push("Google Chrome");
            historicoNavegacao.Push("Youtube");
            historicoNavegacao.Push("Minecraft");
            historicoNavegacao.Push("Wikipedia");

            Console.WriteLine($"Página atual: {historicoNavegacao.Peek()}");

            Console.WriteLine("! Voltando... !");
            while (historicoNavegacao.Count > 0)
            {
                string pagina = historicoNavegacao.Pop();
                Console.WriteLine($"! Voltando de: {pagina} !");
            }

            Console.WriteLine("! Não tem mais páginas !");
        }
    }
}