using System.Linq.Expressions;
using Core.Entities;

namespace Core.DataAccess;

//generic constraint
//class : referanse type
//IEntity : IEntity olabilir beya IEntity implemente eden bir nesne olabilir
//new() :new'lenebilir olmalı
public interface IEntityRepository<T> where T : class, IEntity, new()
{
    List<T> GetAll(Expression<Func<T, bool>> filter = null);
    T Get(Expression<Func<T, bool>> fiter = null);
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
}