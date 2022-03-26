namespace Aula03Encapsulamento.Domain
{
    public class Item
    {
        public Item(int id, string nome)
        {
            this.Id = id;
            this.Nome = nome;
        }
        
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public Mochila Mochila { get; set; }
    }
}