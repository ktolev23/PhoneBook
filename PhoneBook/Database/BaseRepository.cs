using Microsoft.EntityFrameworkCore;
using PhoneBook.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PhoneBook.Database
{
    public class BaseRepository<T> where T : BaseEntity
    {
        protected DbContext Context { get; set; }
        protected DbSet<T> Items { get; set; }

        public BaseRepository()
        {
            Context = new PhoneBookDbContext();
            Items = Context.Set<T>();
        }
        
        public List<T> GetAll()
        {
            return Items.ToList();
        }

        public T GetById(int Id)
        {
            return Items
                     .Where(i => i.Id == Id)
                     .FirstOrDefault();
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> filter)
        {
            return Items
                        .Where(filter)
                        .FirstOrDefault();
        }
        
        public void Add(T item)
        {
            Items.Add(item);
            Context.SaveChanges();
        }
        public void Update(T item)
        {
            Items.Update(item);
            Context.SaveChanges();
        }
        
        public void Delete(T item)
        {
            Items.Remove(item);
            Context.SaveChanges();
        }
    }
}
