namespace pasta3
{
    public class Pessoa
    {
        public Pessoa(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
        public int Id{get; private set;}
        public string Nome{get; private set;}
    }
}