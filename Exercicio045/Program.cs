using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio045
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int qnt = int.Parse(Console.ReadLine());

            p = new Produto(nome, preco, qnt);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            qnt = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qnt);
            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qnt = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qnt);
            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + p);

        }
    }
}
