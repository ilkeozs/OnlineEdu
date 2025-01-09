using Microsoft.EntityFrameworkCore;
using OnlineEdu.DataAccess.Abstract;
using OnlineEdu.DataAccess.Context;
using System.Linq.Expressions;

namespace OnlineEdu.DataAccess.Repositories;

// Primary constructor
public class GenericRepository<T>(OnlineEduContext context) : IRepository<T> where T : class
{
    public DbSet<T> Table { get => context.Set<T>(); }
    public int Count()
    {
        return Table.Count();
    }

    public void Create(T entity)
    {
        Table.Add(entity);
        context.SaveChanges();
    }

    public void Delete(int id)
    {
        var entity = Table.Find(id);
        Table.Remove(entity);
        context.SaveChanges();
    }

    public int FilteredCount(Expression<Func<T, bool>> predicate)
    {
        return Table.Where(predicate).Count();
    }

    public T GetByFilter(Expression<Func<T, bool>> predicate)
    {
        return Table.Where(predicate).FirstOrDefault();
    }

    public T GetById(int id)
    {
        return Table.Find(id);
    }

    public List<T> GetFilteredList(Expression<Func<T, bool>> predicate)
    {
        return Table.Where(predicate).ToList();
    }

    public List<T> GetList()
    {
        return Table.ToList();
    }

    public void Update(T entity)
    {
        Table.Update(entity);
        context.SaveChanges();
    }
}