using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TralhoGumo2
{
    public class Item
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public UInt64 Id { get; set; }
        public uint Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }
        public decimal Desconto { get; set; }
        [ForeignKey("ProdutoId")]
        public ulong ProdutoId { get; set; }
        [NotMapped]
        
        public Produto Produto { get; set; }

        public ulong CompraId { get; set; }
        [ForeignKey("CompraId")]
        public Compra Compra { get; set; }

        public decimal CalcularTotal()
        {
            return (PrecoUnitario * Quantidade) - (PrecoUnitario * Quantidade * Desconto);
        }

        public override string ToString()
        {
            return $"{Produto?.Nome} - R$ {CalcularTotal():F2}";
        }
    }

}
