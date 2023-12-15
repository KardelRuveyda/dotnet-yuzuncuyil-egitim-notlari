using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYil.Core.Repositories
{
    public interface IGenericRepository<T> where T:class
    {
        Task<T> GetByIdAsync(int id);

        //user.GetAll(s => s.UserName == "kardel"); ( Filtreleme yapmak için aşağıdaki expression parametresini function delege olarak tanımlamanız gerekir. )
        IQueryable<T> GetAll(Expression<Func<T,bool>> expression);

        //user.Where(s=> s.userName == "kardel").ToList().OrderBy(); ( Veri tabanına gider sonra sıralama yapar. ) 
        //user.Where(s=> s.userName == "kardel").OrderBy(); ( Veri tabanına gitmeden ön bellekten sıralama yapar. ) 
        IQueryable<T> Where(Expression<Func<T,bool>> expression);
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        void Update(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);

   }
}
