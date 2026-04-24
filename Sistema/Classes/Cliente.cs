using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TralhoGumo2
{
    public class Cliente
    {
        public UInt64 Id { get; set; }
        private DateTime _nascimento;
        [NotMapped]
        public Boolean Pode { get; set; }
        public String Cpf { get; set; }
        public String Nome { get; set; }
        public String Telefone { get; set; }
        public String Endereco { get; set; }
        public DateTime Nascimento 
        {
            get => _nascimento;
            set
            {
                _nascimento = value;
                if (_nascimento.Month > DateTime.Now.Month && _nascimento.Day > DateTime.Now.Day)
                {
                    Idade = (Byte)(DateTime.Now.Year - _nascimento.Year - 1);
                }
                else 
                {
                    Idade = (Byte)(DateTime.Now.Year - _nascimento.Year);
                }
            }
        }
        public Byte Idade { get; private set; }
        public List<Compra> Compras { get; set; } = new List<Compra>();

        public bool PodeRealizarNovaCompra()
        {
            var compras = CompraRepository.FindComprasByClienteId(this.Id);
            foreach (var compra in compras)
            {
                foreach (var pag in compra.Pagamentos)
                {
                    if (pag.Vencimento < DateTime.Now && pag.DataPagamento == default(DateTime))
                        return false;
                }
            }

            return true;
        }

        public override string ToString()
        {
            return $"{Nome} - ID: {Id}";
        }
    }
}
