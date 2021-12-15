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
using Domain.Domain.Helpers;
using Domain.Domain.Dtos.Posts;
using Domain.Domain.Dtos.Responses;

namespace Service.Main
{
    /// <summary>
    /// Ricardo Martinez 
    /// Class Salary Service, in this class 
    /// we can find all the bussiness logic 
    /// from the Salary table like validatinos
    /// and cruds operations
    /// </summary>
    public class SalaryService : BaseService<Salary>, ISalaryService
    {
        #region Property for use

        protected ISalaryRepository salaryRepository;

        #endregion

        #region Constructor
        public SalaryService(ISalaryRepository salaryRepository) : base(salaryRepository)
        {
            this.salaryRepository = salaryRepository;
        }

        #endregion

        #region Validations of the class

        /// <summary>
        ///  Ricardo Martinez.
        ///  Methdo for validate a salary must be
        ///  unique in a year and month
        /// </summary>
        /// <param name="salaries">List to Validate</param>
        /// <returns></returns>
        public bool isUniqueSalaryYearMonth(List<Salary> salaries)
        {
            var query = from b in salaries
                        join s in salaryRepository.GetAll()
                        on new { b.IdentificationNumber, b.Year, b.Month } equals new { s.IdentificationNumber, s.Year, s.Month }
                        select new { b };

            return !query.Any();
        }

        public bool isUniqueNameEmployeeSalary(List<Salary> salaries)
        {
            var query = from b in salaries
                        from s in salaryRepository.GetAll()
                        where (b.EmployeeName == s.EmployeeName && b.EmployeeSurname == s.EmployeeSurname) && b.IdentificationNumber != s.IdentificationNumber
                        select new { b };

            return !query.Any();
        }

        #endregion

        #region Retrive information

        /// <summary>
        /// Ricardo Martinez.
        /// Method for retrive information 
        /// </summary>
        /// <returns></returns>
        public List<SalaryCalculateDTO> getSalaryCalculated()
        {
            return salaryRepository.getSalaryCalculated();
        }

        /// <summary>
        /// Ricardo Martinez.
        /// Retrive information about the last three salaries
        /// of the employee throw the code Employee
        /// </summary>
        /// <param name="codeEmployee"></param>
        /// <returns></returns>
        public SalaryBonusDTO getLasthreeSalaries(string codeEmployee)
        {
            List<Salary> records = salaryRepository.getLastThreeSalariesByCodeEmployee(codeEmployee);
            
            return HelperSalary.getOnlySecuenceSalary(records);
        }

        public List<SalaryPrincipalDTO> getSalariesDTO()
        {
            return salaryRepository.getSalariesPrincipal();
        }


        #endregion

        #region Add and Update Records

        public ResponseSalaryDTO addNewSalary(SalaryPostDTO post)
        {
            List<Salary> salaries = new List<Salary>();
            bool success = true;
            string message = "success";

            //Creating the list o add or edit
            for (int i = 0; i < HelperUtility.MonthDifference(post.toDate.AddDays(1), post.fromDate); i++)
            {
                int id = salaryRepository.getIdByIdentificationYearMonth(post.identification, post.fromDate.AddMonths(i).Year, post.fromDate.AddMonths(i).Month);
                Salary salary = salaryRepository.GetById(id);

                if (salary is null) salary = new Salary();

                salary.Year = post.fromDate.AddMonths(i).Year;
                salary.Month = post.fromDate.AddMonths(i).Month;
                salary.Id = salaryRepository.getIdByIdentificationYearMonth(post.identification, salary.Year, salary.Month);
                salary.EmployeeCode = post.code;
                salary.EmployeeName = post.name;
                salary.EmployeeSurname = post.surname;
                salary.Grade = post.grade;
                salary.BeginDate = post.beginDate;
                salary.Birthday = post.birthDay;
                salary.IdentificationNumber = post.identification;
                salary.BaseSalary = post.baseSalary;
                salary.ProductionBonus = post.productionBonus;
                salary.CompensationBonus = post.compensationBonus;
                salary.Commission = post.comission;
                salary.Contributions = post.contribution;
                salary.OfficeID = post.officeId;
                salary.DivisionID = post.divisionId;
                salary.PositionID = post.positionId;

                salaries.Add(salary);
            }


            //validations
            if (!isUniqueSalaryYearMonth(salaries) && post.updateRecord == false)
            {
                success = false;
                message += "Exists other salary regristered in a month specified";
                return new ResponseSalaryDTO() { success = success, message = message };
            }

            if (!isUniqueNameEmployeeSalary(salaries))
            {
                success = false;
                message += " The FullName of the employee must be unique.";
                return new ResponseSalaryDTO() { success = success, message = message };
            }

            //updating records
            if (!salaryRepository.UpdateRange(salaries.Where(x => x.Id != 0).ToList()))
            {
                success = false;
                message += " Internal error updating salaries in a month";
                return new ResponseSalaryDTO() { success = success, message = message };
            }


            //Adding new records
            if (!salaryRepository.AddRange(salaries.Where(x => x.Id == 0).ToList()))
            {
                success = false;
                message += " Internal error adding new salaries in a month";
                return new ResponseSalaryDTO() { success = success, message = message };
            }
            
            return new ResponseSalaryDTO() { success = success, message = message };
        }

        #endregion
    }
}
