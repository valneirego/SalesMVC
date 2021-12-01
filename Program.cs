using System;
using System.Collections.Generic;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Bom dia !!!!!");

            Console.WriteLine("Como você está");

            List<string> lista = new List<string>();

            lista.Add("Valnei");
            lista.Add("Mariana");
            lista.Add("Júlia");

            foreach (var v in lista)
            {
                System.Console.WriteLine(v);
            }

        }
    }
}
