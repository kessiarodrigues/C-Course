// See https://aka.ms/new-console-template for more information
using System.Globalization;

namespace Aula05{

class Program {
    static void Main(string[] args) {
        Triangulo x, y;

        x = new Triangulo();
        y = new Triangulo();

        Console.WriteLine("Entre com as medidas do tringulo X: ");
        x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Entre com as medidas do tringulo Y: ");
        y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

       
        double areaX = x.Area();
        double areaY = y.Area();

        if (areaY > areaX) {
            Console.WriteLine("A area do trinagulo Y é maior");
        } 
        else {
            Console.WriteLine("A area do triangulo X é maior.");
        }
    }
}
}