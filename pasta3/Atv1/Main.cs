using System;

/*

1 - Gere uma classe que lerá as informações de base e altura de 
triângulos, a classe deve possuir métodos de leitura de dados, de exibição de das informações 
e um método para calcular sua Área. Crie uma classe para testar.

*/

namespace pasta3.Atv1
{
    class atv1Mostrar
    {
        static void Main(string[] args){
            Atv01 tringulo = new Atv01(5, 5);

            tringulo.Total();

            Console.WriteLine(tringulo);
        }
    }
}