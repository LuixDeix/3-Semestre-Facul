namespace Exercicio_1
{
    public class DivisaoInvalida
    {
        public DivisaoInvalida(int value_one, int value_two)
        {
            try
            {
                Console.WriteLine($"   •  Resultado da divisão: {value_one / value_two}");

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine(" ! Divisão por zero não é permitida. !");
            }
        }
    }
}