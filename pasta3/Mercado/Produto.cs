namespace pasta3.Mercado
{
    public class Produto
    {
        public Produto(int id, string nome, double preco, double qtdEtoque = 0)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
            QtdEtoque = qtdEtoque;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public double QtdEtoque { get; set; } = 0;
    }
}