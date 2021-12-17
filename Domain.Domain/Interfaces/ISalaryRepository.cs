using Domain.Domain.Dtos;
using Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain.Interfaces
{
    public interface ISalaryRepository : IBaseRepository<Salary>
    {
        List<SalaryCalculateDTO> getSalaryCalculated();
        List<Salary> getLastThreeSalariesByCodeEmployee(string codeEmployee);
        List<SalaryPrincipalDTO> getSalariesPrincipal();
        int getIdByIdentificationYearMonth(string identification, int year, int month);
        List<EmployeeDTO> getEmployees();
    }
}
