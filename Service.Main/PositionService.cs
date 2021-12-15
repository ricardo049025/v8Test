using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Domain.Interfaces.Services;
using Domain.Domain.Interfaces;
using Domain.Entities.Models;
using Infraestructure.Data.Repositories;
using Domain.Domain.Dtos;

namespace Service.Main
{
    public class PositionService : BaseService<Position>, IPositionService
    {
        protected IPositionRepository positionRepository;

        public PositionService(IPositionRepository positionRepository) : base(positionRepository)
        {
            this.positionRepository = positionRepository;
        }

    }
}
