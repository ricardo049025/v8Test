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
    public class DivisionRepository : BaseRepository<Division>, IDivisionRepository
    {
        protected V8Context context;

        public DivisionRepository(V8Context context) : base(context)
        {
            this.context = context;
        }
    }
}
