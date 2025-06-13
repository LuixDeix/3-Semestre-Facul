namespace Exercicio_2
{
    public class IndiceInvalido
    {
        public IndiceInvalido(int[] array, int indece)
        {
            try
            {
                Console.WriteLine($"   • Valor no índice {indece}: {array[indece]}");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine(" ! Índice fora dos limites do array. !");
            }
        }
    }
}