namespace Exercicio_1
{
    public class List
    {
        static void Primeiro_Exercicio()
        {
            List<int> valor = new List<int>();

            valor.Add(1);
            valor.Add(2);
            valor.Add(3);
            valor.Add(4);
            valor.Add(5);

            Console.WriteLine("|__________Lista:__________| ");
            foreach (int cada in valor)
            {
                Console.WriteLine(cada);
            }
            Console.WriteLine("|__________________________| ");
            Console.WriteLine("|==========================| ");
        }
    }
}