using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TralhoGumo2
{
    public class Produto
    {
        public UInt64 Id { get; set; }
        public String Nome { get; set; }
        public Decimal Preco { get; set; }
        public UInt32 Estoque { get; set; }
        public UInt32 EstoqueMinimo { get; set; } = 10;
        public Boolean Ativo { get; set; } = true;
        public Categoria Categoria { get; set; }
        public override string ToString()
        {
            return $"{Nome} - R$ {Preco:F2} - Id: {Id}"; 
        }

    }
}
