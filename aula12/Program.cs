// See https://aka.ms/new-console-template for more information
namespace aula12 {
    class Program {
        static void Main(string[] args){
            string[] vect = new string[] {"maria", "alex", "paulo"};

            foreach(string obj in vect) {
                Console.WriteLine(obj);
            }
        }
    }
}
