using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TralhoGumo2;

namespace TrabalhoGuisso
{
    public class VendedorRepository
    {
        public static void SaveOrUpdate(Vendedor v)
        {
            try
            {
                using (Repository DbContext = new Repository())
                {
                    if (v.Id == 0)
                    {
                        DbContext.Vendedores.Add(v);
                    }
                    else
                    {
                        DbContext.Entry(v).State = EntityState.Modified;
                    }
                    DbContext.SaveChanges();
                }
            }
            catch
            {
                throw;
            }
        }

        public static List<Vendedor> FindAll()
        {
            try
            {
                using (Repository DbContext = new Repository())
                {
                    return DbContext.Vendedores.ToList();
                }
            }
            catch
            {
                throw;
            }
        }
        public static Vendedor FindById(UInt64 i)
        {
            try
            {
                using (Repository DbContext = new Repository())
                {
                    return DbContext.Vendedores.Find(i);
                }
            }
            catch
            {
                throw;
            }
        }
        public static void Remove(Vendedor v)
        {
            try
            {
                using (Repository DbContext = new Repository())
                {
                    DbContext.Vendedores.Attach(v);
                    DbContext.Vendedores.Remove(v);
                    DbContext.SaveChanges();
                }
            }
            catch
            {
                throw;
            }
        }
        public static List<Vendedor> FindAllWithCredencial()
        {
            try
            {
                using (Repository DbContext = new Repository())
                {
                    return DbContext.Vendedores.Include("Credencial").ToList();
                }
            }
            catch
            {
                throw;
            }
        }
        public static List<Vendedor> FindByPartialName(String s)
        {
            try
            {
                using (Repository DbContext = new Repository())
                {
                    return DbContext.Vendedores.Where(c => c.Nome.Contains(s)).ToList();
                }
            }
            catch
            {
                throw;
            }
        }
        public static Vendedor FindByName(String s)
        {
            try
            {
                using (Repository DbContext = new Repository())
                {
                    return DbContext.Vendedores.Where(c => c.Nome == s).FirstOrDefault();
                }
            }
            catch
            {
                throw;
            }
        }
    }
}