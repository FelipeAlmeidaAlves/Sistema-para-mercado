//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace TralhoGumo2
//{
//    public class ItemRepository
//    {
//        public static void SaveOrUpdate(Item c)
//        {
//            try
//            {
//                using (Repository DbContext = new Repository())
//                {
//                    if (c.Id == 0)
//                    {
//                        DbContext.Itens.Add(c);
//                    }
//                    else
//                    {
//                        DbContext.Entry(c).State = EntityState.Modified;
//                    }
//                    DbContext.SaveChanges();
//                }
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        public static List<Item> FindAll()
//        {
//            try
//            {
//                using (Repository DbContext = new Repository())
//                {
//                    return DbContext.Itens.ToList();
//                }
//            }
//            catch
//            {
//                throw;
//            }
//        }
//    }
//}
