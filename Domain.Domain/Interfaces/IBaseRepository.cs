using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain.Interfaces
{
    /// <summary>
    /// Ricardo Martinez
    /// Base Interface for interactue with
    /// my respositories
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IBaseRepository<TEntity> where TEntity: class
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        bool Add(TEntity entity);
        bool AddRange(List<TEntity> entities);
        bool Update(TEntity entity);
        bool UpdateRange(List<TEntity> entities);
        bool Delete(int id);

    }
}
