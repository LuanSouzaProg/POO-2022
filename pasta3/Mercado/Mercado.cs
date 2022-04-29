using System;
using System.Collections.Generic;

namespace pasta3.Mercado
{
    public class Mercado{
        static Pedido pedidoDoLuan;
        public static void Main(){
            Produto sabonete = new Produto(1, "Sabonete", 2.80, 50);
            Produto cafe = new Produto(2, "Café", 5.00, 30);
            Produto arroz = new Produto(3, "Arroz", 10.60, 80);

            Cliente luan = new Cliente("Luan", 1);
            Cliente Natan = new Cliente("Natan", 2);

            FormaPagamento cartao = new FormaPagamento(1, "Cartão");
            FormaPagamento dinheiro = new FormaPagamento(2, "Dinheiro");

            // Criando um pedido
            pedidoDoLuan = new Pedido(
                1, 
                new DateTime(2022,03,01),
                luan,
                new List<Produto>(){
                    sabonete,
                    cafe,
                }
            );

            pedidoDoLuan.Produtos.Add(arroz);
            pedidoDoLuan.FormaPagamentos.Add(cartao);
            pedidoDoLuan.FormaPagamentos.Add(dinheiro);

            //Imprimir pedido
            ImprimirPedido();
        }
        private static void ImprimirPedido(){
            Console.WriteLine("Pedido do Luan: " + pedidoDoLuan.Cliente.Nome);
            Console.WriteLine("Data: " + pedidoDoLuan.Data.ToShortDateString());
            Console.WriteLine("=================");

            foreach (var item in pedidoDoLuan.Produtos){
                Console.WriteLine(item.Nome);
            }

            Console.WriteLine("=================");

            foreach (var item in pedidoDoLuan.FormaPagamentos){
                Console.WriteLine(item.Nome);
            }
        }
    }
}