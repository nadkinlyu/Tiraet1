using System.Linq;
using Microsoft.EntityFrameworkCore;
using Tiraet1.Data;

namespace Tiraet1.Repo;

public class Repository<T>:IRepository <T> where T:BaseEntity

{
    private readonly AplicationContext context;
    private DbSet<T> entities;
    private string errorMesage = string.Empty;

    public Repository(AplicationContext context)
    {
        this.context = context;
        entities = context.Set<T>();
    }


    public IEnumerable<T> GetAll()
    {
        return entities.AsEnumerable();
    }

    public T Get(long Id)
    {
        return entities.SingleOrDefault(s=> s.ID == Id);
    }

    public void Insert(T entity)
    {
        if (entity == null)
        {
            throw new ArgumentNullException("entity");
        }

        entities.Add(entity);
        context.SaveChanges();

    }

    public void Update(T entity)
    {
        if (entity == null)
        {
            throw new ArgumentNullException("entity");
        }
        context.SaveChanges();
       
    }

    public void Delete(T entity)
    {
        if (entity == null)
        {
            throw new ArgumentNullException("entity");
        }

        entities.Remove(entity);
        context.SaveChanges();
        
    }

    public void Remove(T entity)
    {
        if (entity == null)
        {
            throw new ArgumentNullException("entity");
        }

        entities.Update(entity);
        context.SaveChanges();
    }

    public void SaveChanges()
    {
        context.SaveChanges();
    }
}