using System;

namespace Aula02TestAmbiente.Entities
{
    public class Livro
    {
        int id;
        string titulo;
        decimal valor = 0;
        DateTime dataPublicacao;

        public Autor Autor { get; set; }

        public Livro(int id, string titulo, Autor autor){
            this.id = id;
            this.titulo = titulo;
            this.Autor = autor;
        }
        public int GetId(){
            return this.id;
        }
        public string GetTitulo(){
            return this.titulo;
        }
        public decimal Valor{
            get; 
            set;
            }
    }
}