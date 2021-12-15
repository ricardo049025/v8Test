using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Domain.Interfaces.Services;
using Domain.Domain.Interfaces;
using Domain.Entities.Models;
using Infraestructure.Data.Repositories;

namespace Service.Main
{
    public class BaseService <TEntity> : IBaseService<TEntity> where TEntity : class
    {
        protected IBaseRepository<TEntity> baseRepository;

        public BaseService(IBaseRepository<TEntity> baseRepository)
        {
            this.baseRepository = baseRepository;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return baseRepository.GetAll();
        }

        public TEntity GetById(int id)
        {
            return baseRepository.GetById(id);
        }

        public bool Add(TEntity entity)
        {
            return baseRepository.Add(entity);
        }

        public bool AddRange(List<TEntity> entities)
        {
            return baseRepository.AddRange(entities);
        }

        public bool Update(TEntity entity)
        {
            return baseRepository.Update(entity);
        }
        public bool UpdateRange(List<TEntity> entities)
        {
            return baseRepository.UpdateRange(entities);
        }
        public bool Delete(int id)
        {
            return baseRepository.Delete(id);
        }
    }
}
