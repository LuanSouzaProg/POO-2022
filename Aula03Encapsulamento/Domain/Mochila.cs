using System.Collections.Generic;

namespace Aula03Encapsulamento.Domain
{
    public class Mochila
    {
        public Mochila(int id, string descricao, decimal preco, int quantMax, eCores cor)
        {
            this.Id = id;
            this.Descricao = descricao;
            this.Preco = preco;
            this.QuantMax = quantMax;
            this.Cor = cor;
        }
        public int Id { get; private set; }
        public string Descricao { get; private set; }
        public decimal Preco { get; set; }
        public int QuantMax { get; private set; }
        public eCores Cor { get; set; }
        public List<Item> Itens { get; set; } = new List<Item>();

    }
}