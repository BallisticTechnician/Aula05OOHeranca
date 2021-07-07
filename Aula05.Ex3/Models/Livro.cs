using System;
using System.Collections.Generic;
using System.Text;

namespace Aula05.Ex3.Models
{
    class Livro:Produto
    {
        public string Autor { get; set; }
        public int NumeroPaginas { get; set; }
        public int AnoPublicacao { get; set; }

        public Livro(int id, string nome, string autor) : base(id, nome)
        {
            Autor = autor;
        }

        //Sobrescrever o metodo de desconto definido no pai

        public override decimal CalcularDesconto()
        {
            return base.CalcularDesconto(50);
        }

        public override decimal CalcularDesconto(string cupom)
        {
            return cupom =="FIAPBOOK" ? CalcularDesconto(30) : base.CalcularDesconto(cupom);
        }

    }
}
