using System;
using Aula02TestAmbiente.Entities;

namespace Aula02TestAmbiente
{
    class Program
    {
        static void Main(string[] args)
        {
            //Use control + . para pegar as referencias(imports) dos pacotes
            Console.WriteLine("Hello World!");

            Autor objAutor = new Autor(5, "Luan");
            Livro objLivro = new Livro(1 , "Bancos de dados", objAutor);
            Console.WriteLine(objLivro.GetId() + " = " + objLivro.GetTitulo() + " Autor :" + objAutor.Nome);

            //objLivro.SetValo(190);

            //Console.WriteLine("O valor do livro ficou " + objLivro.GetValor());
        }
    }
}
