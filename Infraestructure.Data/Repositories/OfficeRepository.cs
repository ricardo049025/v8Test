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
    public class OfficeRepository : BaseRepository<Office>, IOfficeRepository
    {
        protected V8Context context;

        public OfficeRepository(V8Context context) : base(context)
        {
            this.context = context;
        }

    }
}
