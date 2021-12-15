using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Domain.Interfaces;
using Domain.Entities.Models;
using Domain.Entities;

namespace Infraestructure.Data.Repositories
{
    public class PositionRepository : BaseRepository<Position>, IPositionRepository
    {
        protected V8Context context;

        public PositionRepository(V8Context context) : base(context)
        {
            this.context = context;
        }
    }
}
