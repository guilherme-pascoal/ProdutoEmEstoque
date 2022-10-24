using System;
using System.Globalization;

namespace Exercicio045
{
    internal class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Estoque { get; private set; }

        public Produto()
        {
        }

        public Produto(string nome, double preco, int qnt)
        {
            Nome = nome;
            Preco = preco;
            AdicionarProdutos(qnt);
        }

        public void AdicionarProdutos(int qnt)
        {
            Estoque += qnt; 
        }

        public void RemoverProdutos(int qnt)
        {
            Estoque -= qnt;
        }

        public double ValorTotalEstoque()
        {
            return Estoque * Preco;
        }

        public override string ToString()
        {
            return $"{Nome}, R$ {Preco.ToString("F2", CultureInfo.InvariantCulture)}, {Estoque} unidades, Total: R$ {ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
