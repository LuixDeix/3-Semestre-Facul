using System;
using AfiguraApp;

namespace QuadardoApp
{
    public class Quadrado : Figura
    {
        public double Lado;

        public override double Calcular_Area()
        {
            Console.WriteLine("Informe o valor do Lado: ");
            Lado = Convert.ToDouble(Console.ReadLine());
            return Lado * Lado;
        }
    }
}