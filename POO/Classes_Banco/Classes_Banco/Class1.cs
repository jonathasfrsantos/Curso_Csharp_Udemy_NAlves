using System;


namespace Classes_Banco{
     class Conta{

        public int Numero { get;  private set; } 
        public string Titular { get; set; }
        public double Saldo { get; private set; }


        public Conta(){

        }

        public Conta (int numero, string titular, double saldo){
            Numero = numero;
            Titular = titular;  
            Saldo = saldo;

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
                Saldo -= valor + 5.0;
            }
          
        }

        public override string ToString()
        {
            return "Titular: " + Titular + " Numero da conta: " + Numero + " Saldo: " + Saldo.ToString("F2"); 
        }




    }
}
