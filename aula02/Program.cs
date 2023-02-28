// See https://aka.ms/new-console-template for more information
namespace MyApp {
    class Program {
        static void Main(string[] args) {
            // int idade = 32;
            // double saldo = 10.35784;
            // string nome = "Maria";

            // Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2} reais", nome, idade, saldo);

            // System.Console.WriteLine($"{nome} tem {idade} anos e tem saldo igaul a {saldo:F2} reais");

            //exercicio
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é {preco1}");
            Console.WriteLine($"{produto2}, cujo preço é {preco2}");

            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");

            Console.WriteLine($"Medida com 8 casas decimais: {medida}");
            Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}");
            
        }
    }
}
