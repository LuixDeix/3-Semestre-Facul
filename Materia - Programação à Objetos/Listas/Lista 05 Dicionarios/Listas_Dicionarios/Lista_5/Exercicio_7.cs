namespace Exercicio_7
{
    class ListSort
    {
        static void Setimo_Exercicio()
        {
            List<int> numeros = new List<int> { 42, 15, 8, 23, 4, 16 };

            Console.WriteLine("|___Lista Original:__| ");
            foreach (int n in numeros)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine("|____________________| ");
            Console.WriteLine("|====================| ");
            Console.WriteLine();
            
            numeros.Sort();

            Console.WriteLine("|___Lista Ordenada:__| ");
            foreach (int n in numeros)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine("|____________________| ");
            Console.WriteLine("|====================| ");
        }
    }
}