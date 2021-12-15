using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain.Interfaces.Services
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        bool Add(TEntity entity);

        bool AddRange(List<TEntity> entity);
        bool Update(TEntity entity);
        bool UpdateRange(List<TEntity> entities);
        bool Delete(int id);
    }
}
