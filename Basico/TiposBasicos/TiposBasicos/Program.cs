using System;

namespace TiposBasicos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá mundo!");


            int n1 = 10000;
            long n2 = 30000000L;          // Usar L ao final para indicar o long
            float n3 = 4.5f;               // Usar F ao final para indicar o float
            double n4 = 4.5;
            int n5 = int.MaxValue;
            string nome = "Maria green";
            object obj1 = "Alex Brown";

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);



        }
    }
}
