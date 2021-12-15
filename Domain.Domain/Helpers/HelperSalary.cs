using Domain.Domain.Dtos;
using Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain.Helpers
{
    public static class HelperSalary
    {
        /// <summary>
        /// Ricardo Martinez.
        /// Method for calculate Total Salary of
        /// a employee.
        /// </summary>
        /// <param name="baseSalary"></param>
        /// <param name="comission"></param>
        /// <param name="productionBonus"></param>
        /// <param name="compensationBonus"></param>
        /// <param name="contribution"></param>
        /// <returns></returns>
        public static decimal calculateTotalSalary (decimal baseSalary, decimal comission, decimal productionBonus, decimal compensationBonus, decimal contribution)
        {
            decimal otherIncome = 0;

            otherIncome = (baseSalary + comission) * (8 / 100) + comission;

            return baseSalary + productionBonus + (compensationBonus * (75 / 100)) + otherIncome - contribution;
        }

        public static SalaryBonusDTO getOnlySecuenceSalary(List<Salary> salaries)
        {
            List<SalaryDTO> salariesDTO = new List<SalaryDTO>();
            SalaryBonusDTO salaryBonusDTO = new SalaryBonusDTO();
            decimal bonus = salaries.Sum(x => x.BaseSalary) / 3;
            int j = 0;
            for (int i = 0; i < salaries.Count; i++)
            {
                SalaryDTO dto = new SalaryDTO();
                dto.Id = salaries[i].Id;
                dto.Month = salaries[i].Month;
                dto.Year = salaries[i].Year;
                dto.BaseSalary = salaries[i].BaseSalary;

                if (i == 0) 
                {
                    salariesDTO.Add(dto);
                    j++;
                }
                else 
                {
                    if (HelperUtility.MonthDifference(new DateTime(salariesDTO[j-1].Year, salariesDTO[j - 1].Month, 1), new DateTime(dto.Year, dto.Month, 1)) == 1)
                    {
                        salariesDTO.Add(dto);
                        j++;
                    }
                }

            }

            salaryBonusDTO.Bonus = bonus;
            salaryBonusDTO.salaries = salariesDTO;

            return salaryBonusDTO;   
        }
                
    }
}
