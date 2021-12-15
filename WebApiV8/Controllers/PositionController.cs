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
    public class PositionController : Controller
    {
        private readonly ILogger<PositionController> _logger;
        private IPositionService positionService;

        public PositionController(ILogger<PositionController> logger, IPositionService positionService)
        {
            this.positionService = positionService;
        }

        [HttpGet]
        public List<Position> Get()
        {
            return positionService.GetAll().ToList();
        }
    }
}
