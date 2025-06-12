namespace Exercicio_4
{
    public class FilaDeAtendimento
    {
        static void Quarto_exercicio()
        {
            Queue<string> FilaDeAtendimento = new Queue<string>();

            FilaDeAtendimento.Enqueue("Jenifer");
            FilaDeAtendimento.Enqueue("Luis");
            FilaDeAtendimento.Enqueue("Dudarts");

            Console.WriteLine("|________Lista de Atendimento:________| ");
            foreach (string pessoa in FilaDeAtendimento)
            {
                Console.WriteLine(pessoa);
            }

            Console.WriteLine("! Iniciando Atendimentos ! ");
            while (FilaDeAtendimento.Count > 0)
            {
                string atendido = FilaDeAtendimento.Dequeue();
                Console.WriteLine($"! Sr(a), {atendido} está em atendimento. !");
            }

            Console.WriteLine("! Todos foram atendidos. !");
        }
    }
}