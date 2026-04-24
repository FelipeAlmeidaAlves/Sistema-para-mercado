using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TralhoGumo2
{
    public class CategoriaRepository
    {
        public static void SaveOrUpdate(Categoria c)
        {
            try
            {
                using (Repository DbContext = new Repository())
                {
                    if (c.Id == 0)
                    {
                        DbContext.Categorias.Add(c);
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

        public static List<Categoria> FindAll()
        {
            try
            {
                using (Repository DbContext = new Repository())
                {
                    return DbContext.Categorias.ToList();
                }
            }
            catch
            {
                throw;
            }
        }
        public static Categoria FindById(UInt64 i)
        {
            try
            {
                using (Repository DbContext = new Repository())
                {
                    return DbContext.Categorias.Find(i);
                }
            }
            catch
            {
                throw;
            }
        }
        public static void Remove(Categoria c)
        {
            try
            {
                using (Repository DbContext = new Repository())
                {
                    DbContext.Categorias.Attach(c);
                    DbContext.Categorias.Remove(c);
                    DbContext.SaveChanges();
                }
            }
            catch
            {
                throw;
            }
        }
        public static List<Categoria> FindByPartialName(String s) 
        {
            try 
            {
                using (Repository DbContext = new Repository()) 
                {
                    return DbContext.Categorias.Where(c => c.Nome.Contains(s)).ToList();
                }
            }
            catch
            {
                throw;
            }
        }
        public static Categoria FindByName(String s)
        {
            try
            {
                using (Repository DbContext = new Repository())
                {
                    return DbContext.Categorias.Where(c => c.Nome == s).FirstOrDefault();
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
