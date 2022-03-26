namespace pasta3.Mercado
{
    public class FormaPagamento
    {
        public int Id {get; set;}
        public string Nome {get; set;}

        public FormaPagamento(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}