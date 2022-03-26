namespace pasta3.Mercado
{
    public class Cliente
    {
        public string Nome {get; private set;}
        public int IdCliente{get; private set;}

        public Cliente(string nome, int idCliente)
        {
            Nome = nome;
            IdCliente = idCliente;
        }
    }
}