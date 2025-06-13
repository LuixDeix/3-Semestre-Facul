using System;

namespace Veiculos
{
    public class Moto : IVeiculo
    {
        public void Acelerar()
        {
            Console.WriteLine("A moto está acelerando!");
        }

        public void Frear()
        {
            Console.WriteLine("A moto está freando.");
        }
    }
}
