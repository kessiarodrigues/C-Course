// See https://aka.ms/new-console-template for more information
using aula15.Entities;
using aula15.Entities.Enums;
namespace aula15 {
    class Program {
        static void Main(string[] args){

            //DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, DateTimeKind.Local);

            // Console.WriteLine(d.Day);

            // string s1 = d.ToLongDateString();
            // string s2 = d.ToLongTimeString();
            // string s3 = d.ToShortDateString();

            Order order = new Order{
                Id = 1,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            
        }
    }
}
