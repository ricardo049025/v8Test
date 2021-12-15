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
    public class DivisionService : BaseService<Division>, IDivisionService
    {
        protected IDivisionRepository divisionRepository;

        public DivisionService(IDivisionRepository divisionRepository) : base(divisionRepository)
        {
            this.divisionRepository = divisionRepository;
        }

    }
}
