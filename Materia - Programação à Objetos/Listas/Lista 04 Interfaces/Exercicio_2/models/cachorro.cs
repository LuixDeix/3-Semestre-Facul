using System;

namespace Animais
{
    public class Cachorro : IAnimal
    {
        public void FazerSom()
        {
            Console.WriteLine("Au Au!");
        }
    }
}
