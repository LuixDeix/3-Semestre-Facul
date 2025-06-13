using System;

namespace boleto 
{
    // Supondo que exista uma interface chamada Ipagamento
    public interface Ipagamento
    {
        void pagamento();
    }

    public class Boleto : Ipagamento
    {
        public void pagamento()
        {
            Console.WriteLine("Pagamento realizado por boleto.");
        }
    }

    public class Cartao : Ipagamento
    {
        public void pagamento()
        {
            Console.WriteLine("Pagamento realizado por cartao.");
        }
        }
    }
}