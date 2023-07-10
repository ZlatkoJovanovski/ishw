using System;
using ishw.Domain.DomainModels;

namespace ishw.Repository.Interface;


public interface IRepository<T> where T : BaseEntity
{
    IEnumerable<T> All { get; }

    T Get(int id);
    void Insert(T entity);
    void Update(T entity);
    void Delete(T entity);
    IEnumerable<object> GetAll();
}
