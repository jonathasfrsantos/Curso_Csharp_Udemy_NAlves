using Microsoft.VisualBasic;
using System;

namespace SaidaDados
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 20;
            double saldo = 1550.30;
            string nome = "Maria Dazzle Anne";

            Console.WriteLine("Olá {0} , de idade {1} anos, seu saldo é {2:F2} ", nome, idade, saldo); //método placeholders
            Console.WriteLine($"Olá {nome}, de idade {idade} anos, seu saldo é {saldo:f2}" ); //método interpolação de strings
            Console.WriteLine("Olá " + nome + " de idade " + idade + " anos " + " seu saldo é " + saldo.ToString("F2")); // concatenação de strings

        }
    }
}