using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TralhoGumo2.Forms
{
    public class PagamentoRepository
    {
        public static void SaveOrUpdate(Pagamento c)
        {
            try
            {
                using (Repository DbContext = new Repository())
                {
                    if (c.Id == 0)
                    {
                        DbContext.Pagamentos.Add(c);
                    }
                    else
                    {
                        DbContext.Entry(c).State = EntityState.Modified;
                    }
                    DbContext.SaveChanges();
                }
            }
            catch
            {
                throw;
            }
        }
        public static List<Pagamento> FindByCompraId(UInt64 compraId)
        {
            var pagamentos = new List<Pagamento>();
            try
            {
                using (Repository DbContext = new Repository())
                {
                    List<Compra> compras = CompraRepository.FindAllWPagamento();
                    foreach (Compra compra in compras)
                    {
                        if (compra.Id == compraId)
                        {
                            if (compra.Pagamentos != null)
                            {
                                foreach (var pagamento in compra.Pagamentos)
                                {
                                    pagamentos.Add(pagamento);
                                }
                            }
                            break;
                        }
                    }
                }
            }
            catch (Exception )
            {
                throw;
            }

            return pagamentos;
        }


    }
}
