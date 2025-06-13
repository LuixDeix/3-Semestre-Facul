using System;

namespace Veiculos
{
    public class Carro : IVeiculo
    {
        public void Acelerar()
        {
            Console.WriteLine("O carro está acelerando!");
        }

        public void Frear()
        {
            Console.WriteLine("O carro está freando.");
        }
    }
}
