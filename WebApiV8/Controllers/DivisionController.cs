using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Domain.Interfaces.Services;
using Domain.Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiV8.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class DivisionController : Controller
    {
        private readonly ILogger<DivisionController> _logger;
        private IDivisionService divisionService;

        public DivisionController(ILogger<DivisionController> logger, IDivisionService divisionService)
        {
            this.divisionService = divisionService;
        }

        [HttpGet]
        public List<Division> Get()
        {
            return divisionService.GetAll().ToList();
        }


    }
}
