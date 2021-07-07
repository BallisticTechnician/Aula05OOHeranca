using System;
using System.Collections.Generic;
using System.Text;

namespace Aula05.Ex3.Models
{
    class Eletronico: Produto
    {
        public bool Garantia { get; set; }
        public Eletronico(int id, string nome, bool garantia) : base(id, nome)
        {
            Garantia = garantia;
        }

        public decimal CalcularGarantia()
        {
            if (Garantia)
            {
                return Preco * 1.1m;
            }
            return 0;
        }
    }
}
