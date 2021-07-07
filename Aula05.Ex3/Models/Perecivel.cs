using System;
using System.Collections.Generic;
using System.Text;

namespace Aula05.Ex3.Models
{
    class Perecivel : Produto
    {
        public DateTime DatadeValidade { get; set; }
        public Perecivel(int id, string nome, DateTime data) : base(id,nome)
        {
            DatadeValidade = data;
        }
    }
}
