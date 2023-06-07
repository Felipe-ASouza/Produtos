using System;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto produto = new Produto(nome, preco, quantidade);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + produto);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int quantidadeEstoque = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(quantidadeEstoque);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + produto);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            quantidadeEstoque = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(quantidadeEstoque);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + produto);
        }
    }
}