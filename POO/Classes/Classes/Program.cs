using Classes;
using System;

namespace POO{
    class Program{
        static void Main(string[] args){

            Triangulo x = new Triangulo();
            Triangulo y = new Triangulo();

            Console.WriteLine("entre com as medidas do triângulo X: ");

            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("entre com as medidas do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine($"A área de X é igual a {areaX.ToString("F2")} ");
            Console.WriteLine($"A área de Y é igual a {areaY.ToString("F2")} ");




        }

    }

}