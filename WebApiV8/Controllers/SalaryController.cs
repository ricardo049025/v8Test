using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Domain.Interfaces.Services;
using Domain.Domain.Dtos;
using Domain.Domain.Dtos.Responses;
using Domain.Domain.Dtos.Posts;

namespace WebApiV8.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SalaryController : ControllerBase
    {
    
        private readonly ILogger<SalaryController> _logger;
        private ISalaryService salaryService;

        public SalaryController(ILogger<SalaryController> logger, ISalaryService salaryService)
        {
            this.salaryService = salaryService;
        }

        [HttpGet]
        public List<SalaryPrincipalDTO> Get()
        {
            return salaryService.getSalariesDTO();
        }

        [HttpPost]
        [Route("AddSalary")]
        public ResponseSalaryDTO PostSalaries([FromBody] SalaryPostDTO post)
        {
            return salaryService.addNewSalary(post);            
        }

        [HttpGet]
        [Route("GetCalculatedSalary")]
        public List<SalaryCalculateDTO> GetSalaryCalculated()
        {
            return salaryService.getSalaryCalculated();
        }
                
        [HttpGet]
        [Route("GetLasthreeSalariesBonus")]        
        public SalaryBonusDTO GetLasthreeSalariesBonus(string employeeCode)
        {
            return salaryService.getLasthreeSalaries(employeeCode);
        }

        [HttpGet]
        [Route("GetEmployees")]
        public List<EmployeeDTO> getEmployees()
        {

            return salaryService.getEmployees();
        }

        [HttpGet]
        [Route("getEmployeesFilter")]
        public List<SalaryCalculateDTO> getEmployeesFilter(string identification, int filterType)
        {

            return salaryService.getSalaryCalculatedbyFilter(identification,filterType);
        }
    }
}
