using System;
using System.Globalization;
namespace AdicionarRemoverEstoque {
    class Program {
        static void Main(string[] args) {

           //CONSTRUTORES
            
            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine()!;
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine()!);

            Produto p = new Produto(nome, preco, quantidade);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();

            Console.Write("Digite o numero de produtos a ser adicionado no estoque: ");
            int qte = int.Parse(Console.ReadLine()!);
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.Write("Digite o numero de produtos a ser REMOVIDO do estoque: ");
            qte = int.Parse(Console.ReadLine()!);
            p.RemoverProdutos(qte);
            Console.WriteLine("Dados atualizados: " + p);

            /*
            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine()!);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();

            Console.Write("Digite o numero de produtos a ser adicionado no estoque: ");
            int qte = int.Parse(Console.ReadLine()!);
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.Write("Digite o numero de produtos a ser REMOVIDO do estoque: ");
            qte = int.Parse(Console.ReadLine()!);
            p.RemoverProdutos(qte);
            Console.WriteLine("Dados atualizados: " + p); */
        }
    }
}