// See https://aka.ms/new-console-template for more information
using aula17.Entities;

namespace aula17
{
    class Progrma
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow that's awesome!");

            Post p1 = new Post(

                DateTime.Parse("21/06/2018 : 13:42:05"),
                "Traveling to New Zeeland",
                "I'm going to visit this wolderful country",
                12
            );
            p1.AddComment(c1);
            p1.AddComment(c2);
            
        }
    }
}
