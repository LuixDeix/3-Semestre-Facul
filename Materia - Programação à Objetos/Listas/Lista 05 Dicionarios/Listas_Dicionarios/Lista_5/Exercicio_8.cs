namespace Exercicio_8
{
    class NumerosPares
    {
        static void OitavoExercicio()
        {
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

            var pares = numeros.Where(n => n % 2 == 0);

            Console.WriteLine("|___Numeros Pares:___| ");
            foreach (int n in pares)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine("|____________________| ");
            Console.WriteLine("|====================| ");
        }
    }
}