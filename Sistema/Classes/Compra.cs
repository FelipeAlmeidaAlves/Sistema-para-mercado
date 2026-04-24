using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TralhoGumo2
{
    public class Compra
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public UInt64 Id { get; set; }

        public UInt64 Numero { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime? Efetivacao { get; set; }
        public Decimal Comissao { get; set; }
        public Decimal Total { get; set; }
        [ForeignKey("ClienteId")]

        public UInt64 ClienteId { get; set; }
        [ForeignKey("ClienteId")]
        public Cliente Cliente { get; set; }
        [ForeignKey("VendedorId")]
        public UInt64 VendedorId { get; set; }
        public Vendedor Vendedor { get; set; }
        public Estado Estado { get; set; } = Estado.Pendente;

        public List<Item> Itens { get; set; } = new List<Item>();
        public List<Pagamento> Pagamentos { get; set; } = new List<Pagamento>();

        public Decimal CalcularTotal()
        {
            return Itens.Sum(i => i.CalcularTotal());
        }

        public Decimal CalcularComissao()
        {
            return CalcularTotal() / 100;
        }

        public Decimal CalcularValorParcela()
        {
            var qtd = Pagamentos.Count;
            return qtd == 0 ? 0 : CalcularTotal() / qtd;
        }
        public void AdicionarPagamento(Pagamento p) 
        {
            int i = 0;
            foreach (Pagamento n in Pagamentos) 
            {
                i++;
            }
            if (i < 6 && this.CalcularTotal()/i >= 50) 
            {
                Pagamentos.Add(p);
            }

        }
        public override String ToString()
        {
            return $"Data: {Inicio} Valor: {Total}" ;
        }
    }
}
