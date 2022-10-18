using System;
using System.Runtime.CompilerServices;

namespace EntradaDados2
{
    class Program
    {
        static void Main(string[] args){

            string[] vet = Console.ReadLine().Split(' ');

            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double saldo = double.Parse(vet[3]);


            Console.WriteLine($" Olá {nome}, sexo {sexo}, idade {idade} . Seu saldo é de R$ {saldo.ToString("F2")}");






        }
    }
}
