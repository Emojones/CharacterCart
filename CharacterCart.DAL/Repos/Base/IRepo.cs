using System.Collections.Generic;
using CharacterCart.Models.Entities.Base;

namespace CharacterCart.DAL.Repos.Base
{
    public interface IRepo<T> where T: EntitiesBase
    {        
        T Find(int id);
        IList<T> GetAll();
        int Add(T entity, bool persist = true);        
        int Update(T entity, bool persist = true);
        int Delete(T entity, bool persist = true);
        int Delete(int id, byte[] timeStamp, bool persist = true);
        int SaveChanges();
    }
}
