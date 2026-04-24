using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TralhoGumo2.Forms;

namespace TralhoGumo2
{
    public class ClienteRepository
    {
        public static void SaveOrUpdate(Cliente c)
        {
            try
            {
                using (Repository DbContext = new Repository())
                {
                    if (c.Id == 0)
                    {
                        DbContext.Clientes.Add(c);
                    }
                    else
                    {
                        DbContext.Entry(c).State = EntityState.Modified;
                    }
                    DbContext.SaveChanges();
                }
                EventosGlobais.OnClientesAtualizados();
            }
            catch
            {
                throw;
            }
        }

        public static List<Cliente> FindAll()
        {
            try
            {
                using (Repository DbContext = new Repository())
                {
                    return DbContext.Clientes.ToList();
                }
            }
            catch
            {
                throw;
            }
        }
        public static Cliente FindById(UInt64 i)
        {
            try
            {
                using (Repository DbContext = new Repository())
                {
                    return DbContext.Clientes.Find(i);
                }
            }
            catch
            {
                throw;
            }
        }
        public static void Remove(Cliente c) 
        {
            try 
            {
                using (Repository DbContext = new Repository()) 
                {
                    DbContext.Clientes.Attach(c);
                    DbContext.Clientes.Remove(c);
                    DbContext.SaveChanges();
                }
            }
            catch
            {
                throw;
            }
        }
        public static List<Cliente> FindByPartialName(String s)
        {
            try
            {
                using (Repository DbContext = new Repository())
                {
                    return DbContext.Clientes.Where(c => c.Nome.Contains(s)).ToList();
                }
            }
            catch
            {
                throw;
            }
        }
        public static Cliente FindByName(String s)
        {
            try
            {
                using (Repository DbContext = new Repository())
                {
                    return DbContext.Clientes.Where(c => c.Nome == s).FirstOrDefault();
                }
            }
            catch
            {
                throw;
            }
        }
        public static Cliente FindByCpf(String s)
        {
            try
            {
                using (Repository DbContext = new Repository())
                {
                    return DbContext.Clientes.Where(c => c.Cpf == s).FirstOrDefault();
                }
            }
            catch
            {
                throw;
            }
        }
        //public static List<Cliente> FindAllWCompras()
        //{
        //    try
        //    {
        //        using (Repository DbContext = new Repository())
        //        {
        //            return DbContext.Clientes.ToList();
        //        }
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}
    }
}
