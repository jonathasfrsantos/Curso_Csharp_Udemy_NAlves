using System;


namespace Classes_Banco
{
     class Conta{

        public int Numero { get; private set; } 
        public string Titular { get; set; }
        public double Saldo { get; private set; }


        public Conta(){

        }

        public Conta (int numero, string titular, double saldo){
            numero = Numero;
            titular = Titular;
            saldo = Saldo;

        }

        public void depositar(double valor)
        {
            Saldo += valor;
        }

        public void sacar(double valor)
        {
            if (valor > Saldo){
                Console.WriteLine("Saldo insuficiente");
            } 
            else
            {
                Saldo -= valor;
            }
          
        }




    }
}
