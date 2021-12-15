using Domain.Domain.Interfaces;
using Domain.Domain.Interfaces.Services;
using Domain.Entities;
using Domain.Entities.Models;
using Infraestructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using Service.Main;
using System.Collections.Generic;

namespace TestV8Project
{
    public class SalaryTests
    {

        #region. Atribute of the test
        //Variable for configure context
        private DbContextOptions<V8Context> options = new DbContextOptionsBuilder<V8Context>().UseSqlServer("server=SANJOSESEGASI03\\SQLEXPRESS; database=v8Testdb; User Id=sa; Password=1234").Options;
        private V8Context context;

        //Repositories of the project 
        private ISalaryRepository salaryRepository;

        //Services of the project
        private ISalaryService salaryService;

        #endregion

        #region Default Constructor

        public SalaryTests()
        {
            context = new V8Context(options);
            salaryRepository = new SalaryRepository(context);

            salaryService = new SalaryService(salaryRepository);
        }

        #endregion

        /// <summary>
        /// Ricardo Martinez.
        /// Validate if the salary in a monty and year
        /// of a employee is unique
        /// </summary>
        [Test]
        public void isUniqueSalaryYearMonth()
        {
            List<Salary> salaries = new List<Salary>();
            Salary salary = new Salary();

            salary.IdentificationNumber = "34877451";
            salary.Year = 2021;
            salary.Month = 7;

            salaries.Add(salary);

            Assert.AreEqual(true, salaryService.isUniqueSalaryYearMonth(salaries));

        }

        /// <summary>
        /// Ricardo Martinez.
        /// Validate when a salary in a month and 
        /// year is not unique
        /// </summary>
        [Test]
        public void isNotUniqueSalaryMonth()
        {
            List<Salary> salaries = new List<Salary>();
            Salary salary = new Salary();

            salary.IdentificationNumber = "34877450";
            salary.Year = 2021;
            salary.Month = 6;

            salaries.Add(salary);
                
            Assert.AreEqual(false, salaryService.isUniqueSalaryYearMonth(salaries));
        }
        /// <summary>
        /// Ricardo Martinez
        /// Method for validate a Name is not
        /// duplicated in the database
        /// </summary>
        [Test]
        public void validateIsNotDuplicateNameSalary()
        {
            List<Salary> salaries = new List<Salary>();
            Salary salary = new Salary();

            salary.IdentificationNumber = "34877450";
            salary.EmployeeName = "LUIS";
            salary.EmployeeSurname = "JUAREZ";
            salary.Year = 2021;
            salary.Month = 7;

            salaries.Add(salary);

            Assert.AreEqual(true, salaryService.isUniqueNameEmployeeSalary(salaries));
        }

        /// <summary>
        /// Ricardo Martinez.
        /// Method for validate a Name is 
        /// duplicate in the Database
        /// </summary>
        [Test]
        public void validateIsDuplicateNameSalary()
        {
            List<Salary> salaries = new List<Salary>();
            Salary salary = new Salary();

            salary.IdentificationNumber = "34877451";
            salary.EmployeeName = "LUIS";
            salary.EmployeeSurname = "JUAREZ";
            salary.Year = 2021;
            salary.Month = 7;

            salaries.Add(salary);

            Assert.AreEqual(false, salaryService.isUniqueNameEmployeeSalary(salaries));
        }

        /// <summary>
        /// Ricardo Martinez.
        /// Test for get Information calculated
        /// </summary>
        [Test]
        public void getSalaryCalculated()
        {
            var data = salaryService.getSalaryCalculated();

            Assert.AreEqual(true, data.Count > 0 ? true : false);
        }

        /// <summary>
        /// Ricardo Martinez.
        /// Method for validate a 
        /// </summary>
        [Test]
        public void getLasthreeSalaries()
        {
            var data = salaryService.getLasthreeSalaries("2032440");

            Assert.AreEqual(true, data.salaries.Count > 0 ? true : false);
        }

    }
}