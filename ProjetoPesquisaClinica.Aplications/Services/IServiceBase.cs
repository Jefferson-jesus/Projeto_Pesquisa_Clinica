using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPesquisaClinica.Aplications.Services
{
   public interface IServiceBase<T> : IDisposable where T : class
    {
        T Add(T obj);
        T AddSaveChanges(T obj);
        Task<T> AddSaveChangesAsync(T obj);
        T GetById(int id);
        Task<T> GetByIdAsync(int id);
        T GetByIdReadOnly(int id);
        Task<T> GetByIdAsyncReadOnly(int? id);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAll(int t, int s);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetAllAsync(int t, int s);
        T Update(T obj);
        T UpdateSaveChanges(T obj);
        Task<T> UpdateSaveChangesAsync(T obj);
        void Remove(int id);
        Task RemoveAsync(int id);
        void Remove(T obj);
        IEnumerable<T> Search(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> SearchAsync(Expression<Func<T, bool>> predicate);
        T SearchFirstOrDefault(Expression<Func<T, bool>> predicate);
        Task<T> SearchFirstOrDefaultAsync(Expression<Func<T, bool>> predicate);
        int SaveChanges();
        Task<int> SaveChangesAsync();
        void AddControl(T obj);
    }
}
