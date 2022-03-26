using System;
using System.Collections.Generic;

namespace pasta3
{
    class Program
    {
        static List<Pessoa> pessoas = new List<Pessoa>();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Pessoa pessoa = new Pessoa(1, "Luan");
            Pessoa pessoa2 = new Pessoa(2, "Natan");

            pessoas.Add(pessoa);
            pessoas.Add(pessoa2);

            foreach (var item in pessoas)
            {
                Console.WriteLine(item.Nome);
            }
        }
    }
}
