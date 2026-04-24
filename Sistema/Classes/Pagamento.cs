using System;

namespace TralhoGumo2
{
    public class Pagamento
    {
        public UInt64 Id { get; set; }
        private DateTime _dataPagamento;
        public DateTime Vencimento { get; set; }
        public DateTime DataPagamento
        {
            get => _dataPagamento;
            set
            {
                Compra c;
                _dataPagamento = value;
                if (DataPagamento > Vencimento)
                {
                    int quantmeses = (int)(DataPagamento.Year - Vencimento.Year) * 12;
                    quantmeses += DataPagamento.Month - Vencimento.Month;
                    quantmeses += DataPagamento.Day > Vencimento.Day ? 1 : 0;
                    c = CompraRepository.FindCompraByPagamentoId(this.Id);
                    this.MultaAtraso = c.CalcularValorParcela() * (Decimal)Math.Pow(1.02, quantmeses);
                }
                else
                {
                    this.MultaAtraso = 0m;
                }
            }
        }
        public Decimal MultaAtraso { get; private set; }
    }
}
