using CharacterCart.DAL.EfStructures;
using CharacterCart.Models.Entities.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CharacterCart.DAL.Repos.Base
{
    public abstract class RepoBase<T> : IDisposable, IRepo<T> where T : EntitiesBase, new()
    {
        private readonly bool _disposeContext;
        protected readonly DbSet<T> Table;
        public CharacterCartContext Context { get; }

        //gives the repo access to the db context
        protected RepoBase(CharacterCartContext context)
        {
            Context = context;
            Table = Context.Set<T>();
        }

        //sets up an instance of the repo for unit tests 
        protected RepoBase() : this(new CharacterCartContextFactory().CreateDbContext(new string[0]))
        {
            _disposeContext = true;
        }

        public virtual int Add(T entity, bool persist = true)
        {
            Table.Add(entity);
            return persist ? SaveChanges() : 0;
        }


        public int Delete(T entity, bool persist = true)
        {
            Table.Remove(entity);
            return persist ? SaveChanges() : 0;
        }


        public int Delete(int id, byte[] timeStamp, bool persist = true)
        {
            var entry = GetEntryFromChangeTracker(id);
            if (entry != null)
            {
                if (timeStamp != null && entry.TimeStamp.SequenceEqual(timeStamp))
                {
                    return Delete(entry, persist);
                }
                throw new Exception("Unable to delete due to concurrency");
            }
            Context.Entry(new T { Id = id, TimeStamp = timeStamp }).State = EntityState.Deleted;
            return persist ? SaveChanges() : 0;
        }


        //Deleting and entity using EntityState and the primary key and concurrency columns can save a round trip to the database, but the entity must not be in the ChangeTracker.If it is, Remove is called on the entity in the DbSet. 
        internal T GetEntryFromChangeTracker(int? id)
        {
            return Context.ChangeTracker.Entries<T>()
                .Select((EntityEntry e) => (T)e.Entity).FirstOrDefault(x => x.Id == id);
        }

        public void Dispose()
        {
            if (_disposeContext)
            {
                Context.Dispose();
            }
        }

        public T Find(int id) => Table.Find(id);

        public virtual IList<T> GetAll() => Table.ToList();
        
            

        public int Update(T entity, bool persist = true)
        {
            Table.Update(entity);
            return persist ? SaveChanges() : 0;
        }

        public int SaveChanges()
        {
            try
            {
                return Context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            catch (RetryLimitExceededException ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
    }
}
