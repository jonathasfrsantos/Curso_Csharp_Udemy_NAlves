using System;

namespace Classes2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com os dados do produto:");
            Console.WriteLine("Nome: ");
            string Nome = Console.ReadLine();
            Console.WriteLine("Preço: ");
            double Preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade no estoque: ");
            int Quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(Nome, Preco, Quantidade);


  

            Console.WriteLine(p);

            Console.WriteLine("Digite a quantidade de produtos a ser adicionado");
            int qtd = int.Parse(Console.ReadLine());

            p.AdicionarAoEstoque(qtd);

            Console.WriteLine("Dados adicionados " + p);

            Console.WriteLine("Quantos produtos deseja remover?");

            int qtdRemover = int.Parse(Console.ReadLine());

            p.RemoverProduto(qtdRemover);

            Console.WriteLine("Dados adicionados" + p);

     
            p.Nome = "TV LCD 80";       // na hora de chamar os métodos getter e setter por meio dos properties, não se deve usar o abre e fecha parênteses ( )
           // p.Preco = 3500.00;     
           //  p.Quantidade = 15;

            Console.WriteLine(p);


        }
    }
}

