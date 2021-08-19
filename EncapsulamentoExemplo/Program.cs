using System;

namespace EncapsulamentoExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto("TV", 500.00, 10);

            produto.SetNome("T");

            Console.WriteLine(produto.GetNome());
            Console.WriteLine(produto.GetPreco());
        }
    }
}
