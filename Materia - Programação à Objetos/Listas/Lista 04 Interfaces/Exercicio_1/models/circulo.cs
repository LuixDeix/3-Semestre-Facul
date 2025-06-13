using System;
using AfiguraApp;  

namespace CirculoApp
{
    public class Circulo : Figura
    {
        public double Area;
        public double Raio;

        public override double Calcular_Area()
        {
            Console.WriteLine("Digite o valor do raio: ");
            Raio = Convert.ToDouble(Console.ReadLine()); 
            Area = Math.PI * Math.Pow(Raio, 2);  
            return Area; 
        }
    }
}
