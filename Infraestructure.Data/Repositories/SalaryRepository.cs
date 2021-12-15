using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Domain.Interfaces;
using Domain.Entities.Models;
using Domain.Entities;
using Domain.Domain.Dtos;
using Microsoft.EntityFrameworkCore;
using Domain.Domain.Helpers;

namespace Infraestructure.Data.Repositories
{
    public class SalaryRepository : BaseRepository<Salary>, ISalaryRepository
    {
        protected V8Context context;

        public SalaryRepository(V8Context context) : base(context)
        {
            this.context = context;
        }

        public int getIdByIdentificationYearMonth(string identification, int year, int month)
        {
            return context.Salaries.Where(x => x.IdentificationNumber == identification && x.Year == year && x.Month == month)
                                   .Select(y => y.Id).FirstOrDefault();
        }

        /// <summary>
        /// Ricardo Martinez
        /// Retrive information about total
        /// salary of an Employee
        /// </summary>
        /// <returns></returns>
        public List<SalaryCalculateDTO> getSalaryCalculated()
        {
            var query = from e in context.Salaries.AsNoTracking()
                        group e by new { e.EmployeeName, e.EmployeeSurname, e.IdentificationNumber } into g
                        select new Salary
                        {
                            EmployeeSurname = g.Key.EmployeeSurname,
                            EmployeeName = g.Key.EmployeeName,
                            IdentificationNumber = g.Key.IdentificationNumber,
                            Year = g.Max(y => y.Year),
                            Month = g.Max(y => y.Month)
                        };

            var query2 = from e in query
                         join s in context.Salaries.AsNoTracking().Include(x => x.Division)
                                                   .Include(y => y.Position)
                                                   .Include(z => z.Office)
                         on new { e.IdentificationNumber, e.Year, e.Month } equals new { s.IdentificationNumber, s.Year, s.Month }
                         select new SalaryCalculateDTO
                         {
                             FullName = ($"{e.EmployeeName} {e.EmployeeSurname}"),
                             Divition = s.Division.Name,
                             Position = s.Position.Name,
                             BeginDate = s.BeginDate,
                             Birthday = s.Birthday,
                             IdentificationNumber = e.IdentificationNumber,
                             TotalSalary = HelperSalary.calculateTotalSalary(s.BaseSalary,s.Commission,s.ProductionBonus,s.CompensationBonus,s.Contributions)
                         };

            return query2.ToList();   
        }

        public List<Salary> getLastThreeSalariesByCodeEmployee(string codeEmployee)
        {
            return context.Salaries.Where(x => x.EmployeeCode == codeEmployee)
                                    .OrderByDescending(y => y.Year)
                                    .ThenByDescending(z => z.Month)
                                    .Take(3).ToList();
        }

        public List<SalaryPrincipalDTO> getSalariesPrincipal()
        {
            var query = from b in context.Salaries.AsNoTracking()
                        select new SalaryPrincipalDTO
                        {
                            id = b.Id,
                            year = b.Year,
                            month = b.Month,
                            name = b.EmployeeName,
                            surname = b.EmployeeSurname,
                            grade = b.Grade,
                            beginDate = b.BeginDate,
                            birthday = b.Birthday,
                            identification = b.IdentificationNumber,
                            employeeCode = b.EmployeeCode,
                            baseSalary = b.BaseSalary,
                            productionBonus = b.ProductionBonus,
                            compensationBonus = b.CompensationBonus,
                            comission = b.Commission,
                            contribution = b.Contributions,
                            officeId = b.OfficeID,
                            positionId = b.PositionID,
                            divisionId = b.DivisionID
                        };

            return query.ToList();
        }
    }
}
