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
    [Route("[controller]")]
    public class OfficeController : Controller
    {
        private readonly ILogger<OfficeController> _logger;
        private IOfficeService officeService;

        public OfficeController(ILogger<OfficeController> logger, IOfficeService officeService)
        {
            this.officeService = officeService;
        }

        [HttpGet]
        public List<Office> Get()
        {
            return officeService.GetAll().ToList();
        }
    }
}
