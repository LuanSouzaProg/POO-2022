using System;
using Aula03Encapsulamento.Domain;

namespace Aula03Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteMsg("Criar o objeto mochila");

            Mochila mochila1 =  new Mochila(1, "Mochila de notebook", 199,10, eCores.Preto);
            WriteMsg($"Nome {mochila1.Descricao}, Cor: {mochila1.Cor}");

            Item celular =  new Item(100, "Nokia 3030");
            Item caneta = new Item(102, "Caneta preta");

            mochila1.Itens.Add(celular);
            mochila1.Itens.Add(caneta);

            WriteMsg("Os itens que estão na mochila são: ");

            foreach (var item in mochila1.Itens){
                WriteMsg(item.Nome);
            }

        }
        private static void WriteMsg(string msg){
            Console.WriteLine(msg);
        }
    }
}
