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
    }
}
