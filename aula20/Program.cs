// See https://aka.ms/new-console-template for more information
using aula20.Entities.Enums;
using aula20.Entities;

namespace aula20{
    class Program{
        static void Main(String[] args){

            List<Shape> list = new List<Shape>();


            Console.WriteLine("Enter the number of the shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++ )
            {
                Console.WriteLine(  $"Shape #{i} data: ");
                Console.Write("Rectangle or circle? ");
                char ch = char.Parse(Console.ReadLine());   
                Console.Write("Color: ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (ch == 'r'){
                    Console.WriteLine("Width: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine());
                    list.Add(new Rectangle(width, height, color));
                }
                else
                {
                    System.Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    list.Add(new Circle(radius, color));
                }
            }
            System.Console.WriteLine();
                System.Console.WriteLine("Shape Areas: ");
                foreach(Shape shape in list)
                {
                    System.Console.WriteLine(shape.Area().ToString("F2"));
                }
        }
    }
}
