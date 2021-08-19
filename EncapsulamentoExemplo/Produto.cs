using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulamentoExemplo
{
    class Produto
    {
        //Atributos privados, por isso se utiliza "_" antes do nome do atributo.
        private string _nome;
        private double _preco;
        private int _quantidade;

        //Contrutor Padrão
        public Produto()
        {

        }

        //Construtor adicionado para exigir que os dados sejam informados
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        //Novo construtor que recebe apenas os parametros nome e preco, com a quantidade já definida.
        public Produto(string nome, double preco)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = 5;
        }


        //Metodo para obter o nome
        public string GetNome()
        {
            return _nome;
        }

        //Metodo para definir o nome
        public void SetNome(string nome)
        {
            //Se o valor for nulo, ou menor que 1
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }

        }

        public double GetPreco()
        {
            return _preco;
        }

        public double GetQuantidade()
        {
            return _quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
    }
}
