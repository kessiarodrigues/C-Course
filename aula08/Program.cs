// See https://aka.ms/new-console-template for more information
using System.Globalization;

namespace Aula08 {
    class Program {
        static void Main(String[] args){

            Console.WriteLine("Entre os dados do produto: ");

            Console.WriteLine("Nome do produto: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Produto p = new Produto(nome, preco);

            Console.WriteLine("Dados do Produto: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a serem adicionados ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a serem removidos ao estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

        }
    }
}

