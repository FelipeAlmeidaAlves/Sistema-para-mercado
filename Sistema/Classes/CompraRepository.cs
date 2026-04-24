using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TralhoGumo2
{
    public class CompraRepository
    {
        public static void SaveOrUpdate(Compra compra)
        {
            try
            {
                using (Repository DbContex = new Repository())
                {
                    // impede EF de tentar recriar cliente/vendedor
                    DbContex.Entry(compra).Reference(c => c.Cliente).IsModified = false;
                    DbContex.Entry(compra).Reference(c => c.Vendedor).IsModified = false;

                    if (compra.Id == 0)
                    {
                        DbContex.Add(compra);
                    }
                    else
                    {
                        DbContex.Entry(compra).State = EntityState.Modified;
                    }

                    DbContex.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Compra> FindAll()
        {
            try
            {
                using (Repository DbContext = new Repository())
                {
                    return DbContext.Compras.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Compra FindById(UInt64 Id)
        {
            try
            {
                using (Repository DbContext = new Repository())
                {
                    return DbContext.Compras.Find(Id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Remove(Compra c)
        {
            try
            {
                using (Repository DbContext = new Repository())
                {
                    DbContext.Compras.Attach(c);
                    DbContext.Compras.Remove(c);
                    DbContext.SaveChanges();
                }
            }
            catch
            {
                throw;
            }
        }

        public static List<Compra> FindAllWPagamento()
        {
            try
            {
                using (Repository DbContext = new Repository())
                {
                    return DbContext.Compras.Include(c => c.Pagamentos).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Compra> FindAllWVendedor()
        {
            try
            {
                using (Repository DbContext = new Repository())
                {
                    return DbContext.Compras.Include("Vendedor").ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static List<Compra> FindAllWVendedorAndItens()
        {
            try
            {
                using (Repository DbContext = new Repository())
                {
                    return DbContext.Compras.Include("Vendedor").Include(c => c.Itens).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Compra> FindAllWCliente()
        {
            try
            {
                using (Repository DbContext = new Repository())
                {
                    return DbContext.Compras.Include("Cliente").ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static List<Compra> FindAllWClienteVendedorPagamento()
        {
            try
            {
                using (Repository DbContext = new Repository())
                {
                    return DbContext.Compras.Include("Cliente").Include("Vendedor").Include(c=> c.Pagamentos).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static Compra FindByIdWClienteVendedorPagamento(UInt64 i)
        {
            try
            {
                using (Repository DbContext = new Repository())
                {
                    return DbContext.Compras.Include("Cliente").Include("Vendedor").Include(c => c.Pagamentos).Where(c => c.Id == i).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Compra FindCompraByPagamentoId(UInt64 id)
        {
            try
            {
                using (Repository DbContext = new Repository())
                {
                    Compra variavel = null;
                    List<Compra> compras = CompraRepository.FindAllWPagamento();
                    foreach (Compra c in compras)
                    {
                        foreach (Pagamento p in c.Pagamentos)
                        {
                            variavel = DbContext.Compras.Include("Pagamento").Where(p => p.Id == id).FirstOrDefault<Compra>();
                        }
                    }
                    return variavel;
                }
            }
            catch
            {
                throw;
            }
        }
        public static List<Compra> FindComprasByClienteId(UInt64 id)
        {
            try
            {
                using (Repository DbContext = new Repository())
                {
                    return DbContext.Compras
                        .Include("Pagamentos")
                        .Include("Cliente")
                        .Where(c => c.ClienteId == id)
                        .ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
