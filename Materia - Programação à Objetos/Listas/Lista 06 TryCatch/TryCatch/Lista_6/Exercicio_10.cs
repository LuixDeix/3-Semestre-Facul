using Models.ContaBancaria;

namespace Exercicio_10
{
    public class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException(string mensagem) : base(mensagem) { }
    }
    public class SaqueExcedido
    {
        public SaqueExcedido(ContaBancaria conta, decimal saque)
        {
            try
            {
                conta.Sacar(saque);
                Console.WriteLine($"Saque de {saque} realizado com sucesso. Saldo restante: {conta.Saldo}");
            }
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}