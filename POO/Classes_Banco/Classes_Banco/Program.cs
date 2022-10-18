using System;

namespace Classes_Banco{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Criação de contas: ");
            Console.WriteLine("Entre com o número da conta: ");
            int numConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o titular da conta: ");
            string titular = Console.ReadLine();

            Console.WriteLine("Haverá depósito inicial (s/n) ?");
            char resp = char.Parse(Console.ReadLine().ToUpper());
            
            double depositoInicial = 0;
            if (resp == 'S')

            {
                Console.WriteLine("Entre com o valor do depósito inicial: ");
                depositoInicial = double.Parse(Console.ReadLine());
            }

            Conta c1 = new Conta(numConta, titular, depositoInicial);

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(c1);

            Console.WriteLine("Entre com um valor para deposito: ");
            double valorDeposito = double.Parse(Console.ReadLine());

            c1.depositar(valorDeposito);

            Console.WriteLine("Dados da conta atualizado: ");
            Console.WriteLine(c1);

            Console.WriteLine("Entre com um valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine());

            c1.sacar(valorSaque);

            Console.WriteLine("Dados da conta atualizado: ");
            Console.WriteLine(c1);





        }

    }
}


