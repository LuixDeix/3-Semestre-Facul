namespace Exercicio_2
{
    public class Dictionary
    {
        static void Segundo_Exercicio()
        {
            Dictionary<string, double> alunos = new Dictionary<string, double>();

            alunos.Add("Jenifer", 5.5);
            alunos.Add("Luís", 9.0);
            alunos.Add("Dudarts", 10.0);

            Console.WriteLine("");
            Console.WriteLine("|_________Boletim:_________| ");
            foreach (KeyValuePair<string, double> entrada in alunos)
            {
                Console.WriteLine($"Aluno: {entrada.Key}, Nota: {entrada.Value}");
            }
            Console.WriteLine("|__________________________| ");
            Console.WriteLine("|==========================| ");
        }
    }
}
