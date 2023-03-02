// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;

namespace aula13{
    class Program{
        static void Main(string[] args){
            List<string> list = new List<string>();

            list.Add("Maria"); //adicionar na ondem normal
            list.Add("João");
            list.Add("Ana");
            list.Insert( 10, "Ana"); //adicona em uma posição especifica;

            Console.WriteLine(list.Count);   //indica tamanh da lista  
            }

            //string s1 = list.Find(x -> x[0] == 0 ); //encontrar algo especifico na lista;
    }
} 
