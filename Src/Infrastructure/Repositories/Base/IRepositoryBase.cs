using System.Linq.Expressions;
using SharedKernel.Enumerations;

namespace Infrastructure.Repositories.Base
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> FindAll();
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
        IQueryable<T> AddCondition(IQueryable<T> query, Expression<Func<T, bool>> expression);
        void Create(T entity);
        void CreateRange(List<T> entity);
        void Update(T entity);
        void UpdateRange(List<T> entity);
        void Delete(T entity);
        void DeleteRange(List<T> entity);
        int Save();
        Task<int> SaveAsync();
        List<T> ToList(IQueryable<T> query, Expression<Func<T, object>> sortExpression = null, SortDirection sortDirection = SortDirection.Ascending);
        Task<List<T>> ToListAsync(IQueryable<T> query, Expression<Func<T, object>> sortExpression = null, SortDirection sortDirection = SortDirection.Ascending);
        List<T> ToPagedList(IQueryable<T> query, int pageNumber, int pageSize, Expression<Func<T, object>> sortExpression = null, SortDirection sortDirection = SortDirection.Ascending);
        Task<List<T>> ToPagedListAsync(IQueryable<T> query, int pageNumber, int pageSize, Expression<Func<T, object>> sortExpression = null, SortDirection sortDirection = SortDirection.Ascending);
    }
}