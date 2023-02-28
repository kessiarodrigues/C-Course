// See https://aka.ms/new-console-template for more information
namespace Aula03 {
    class Program {
        static void Main(string[] args) {
            System.Console.WriteLine("Qual a hora atual?");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12) {
                System.Console.WriteLine("Bom dia!");
            }
            else if (hora < 18) {
                System.Console.WriteLine("Boa tarde!");
            }
            else {
                Console.WriteLine("Boa noite");
            }
        }
    }
}
