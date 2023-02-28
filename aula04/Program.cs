// See https://aka.ms/new-console-template for more information
namespace aula04 {
    class Program {
        static void Main(string[] args) {
            System.Console.Write("Quantos números inteiros? ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++) {
                Console.Write("Valor #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
            }
        }
    }
}
