using System;
using System.Collections.Generic;
using System.Text;

namespace Aula05.Ex3.Models
{
    class Produto
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco{ get; set; }
        public Fornecedor Fornecedor { get; set; }
        public decimal Desconto { get; set; }

        public Produto(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
        //Sobrecarga de método : método com mesmo nome e parâmetros diferentes
        public virtual decimal CalcularDesconto()
        {
            return CalcularDesconto(5);
        }
        public decimal CalcularDesconto(decimal Desconto)
        {
            return Preco - (Preco * (Desconto/100));
        }

        public virtual decimal CalcularDesconto(string cupom)
        {
            if (cupom.Equals("fiap10"))
            {
                return CalcularDesconto(20);
            }
            return 0;
        }
 
    }


        }
   
