using System;

namespace Classes2
{
    class Produto
    {

        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }



        // Construtor sem argumentos
        public Produto()
        {

        }

        // Construtor com argumentos
        public Produto(string nome, double preco, int quantidade) // devido a regras de nomeação o uso do this não é tão necessário
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        // Métodos getters e setters

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }


        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarAoEstoque(int quantidade)
        {
            Quantidade += quantidade;

        }

        public void RemoverProduto(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome + ", $" + Preco.ToString("F2") + ", " + Quantidade + " unidades";
        }



    }
}

