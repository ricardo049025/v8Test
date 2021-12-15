using Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    /// <summary>
    /// Ricardo Martinez.
    /// Creating context for create and access
    /// to the database.
    /// </summary>
    public class V8Context : DbContext
    {
        /// <summary>
        /// Ricardo Martinez.
        /// Default Contructor of the context
        /// </summary>
        /// <param name="options"></param>
        public V8Context(DbContextOptions<V8Context> options) : base(options)
        {            
        }

        /// <summary>
        /// Ricardo Martinez.
        /// Method for create records to table when 
        /// run the migration for the database
        /// </summary>
        /// <param name="builder"></param>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            V8Seeder.SeedDivition(builder);
            V8Seeder.SeedOffice(builder);
            V8Seeder.SeedPosition(builder);
            V8Seeder.SeedSalary(builder);
        }

        public virtual DbSet<Division> Divisions { set; get; }
        public virtual DbSet<Office> Offices { set; get; }
        public virtual DbSet<Position> Positions { set; get; }
        public virtual DbSet<Salary> Salaries { set; get; }
    }
}
