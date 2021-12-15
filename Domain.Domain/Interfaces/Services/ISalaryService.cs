using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Domain.Dtos;
using Domain.Domain.Dtos.Posts;
using Domain.Domain.Dtos.Responses;
using Domain.Entities.Models;
namespace Domain.Domain.Interfaces.Services
{
    public interface ISalaryService : IBaseService<Salary>
    {
        bool isUniqueSalaryYearMonth(List<Salary> salaries);
        bool isUniqueNameEmployeeSalary(List<Salary> salaries);
        List<SalaryCalculateDTO> getSalaryCalculated();
        SalaryBonusDTO getLasthreeSalaries(string codeEmployee);
        List<SalaryPrincipalDTO> getSalariesDTO();
        ResponseSalaryDTO addNewSalary(SalaryPostDTO post);
    }
}
