using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TralhoGumo2.Forms;

namespace TralhoGumo2
{
    public class ProdutoRepository
    {
        public static void SaveOrUpdate(Produto p)
        {
            try
            {
                using (Repository DbContext = new Repository())
                {
                    if(p.Categoria != null) 
                    {
                        if (p.Categoria.Id != 0)
                        {
                            DbContext.Categorias.Attach(p.Categoria);
                        }
                        else 
                        {
                            p.Categoria = null;
                        }
                    }
                    
                    if (p.Id == 0)
                    {
                        DbContext.Produtos.Add(p);
                    }
                    else
                    {
                        DbContext.Entry(p).State = EntityState.Modified;
                    }
                    DbContext.SaveChanges();
                }
                EventosGlobais.OnProdutosAtualizados();

            }
            catch
            {
                throw;
            }
        }

        public static List<Produto> FindAll()
        {
            try
            {
                using (Repository DbContext = new Repository())
                {
                    return DbContext.Produtos.Include("Categoria").ToList();
                }
            }
            catch
            {
                throw;
            }
        }
        public static Produto FindById(UInt64 i)
        {
            try
            {
                using (Repository DbContext = new Repository())
                {
                    return DbContext.Produtos.Include("Categoria").Where(c => c.Id == i).FirstOrDefault();
                }
            }
            catch
            {
                throw;
            }
        }
        public static void Remove(Produto p)
        {
            try
            {
                using (Repository DbContext = new Repository())
                {
                    DbContext.Produtos.Attach(p);
                    DbContext.Produtos.Remove(p);
                    DbContext.SaveChanges();
                }
            }
            catch
            {
                throw;
            }
        }
        public static List<Produto> FindByPartialName(String s)
        {
            try
            {
                using (Repository DbContext = new Repository())
                {
                    return DbContext.Produtos.Include("Categoria").Where(c => c.Nome.Contains(s)).ToList();
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
