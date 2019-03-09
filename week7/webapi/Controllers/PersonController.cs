using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Database;
using Microsoft.AspNetCore.Authorization;

namespace webapi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PersonController : ControllerBase
    {
        private readonly SchoolDatabase _dbContext;

        public PersonController(SchoolDatabase dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        [Authorize]
        public ActionResult<List<Person>> GetAllPersons()
        {
            return Ok(_dbContext.Person.Include(p => p.student).ToList());
        }

    }
}
