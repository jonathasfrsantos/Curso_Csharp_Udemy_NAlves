using System;

namespace Condicional_IF_ELSE
{
    class Program
    {
        static void Main(string[] args){

            Console.WriteLine( "entre com um número inteiro: ");

            int x = int.Parse(Console.ReadLine());

            if( x % 2 == 0)
            {
                Console.WriteLine("Par");
            }
            else
            {
                Console.WriteLine("Ímpar");
            }

        }
    }
}