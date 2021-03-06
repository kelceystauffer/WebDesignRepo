using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Database;

namespace webapi.Controllers
{
  [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Person>> Get()
        {
            return getPersons();
        }

        private List<Person> getPersons()
        {
            return InMemory.persons;
        }   

        [HttpPost]
        public void Post([FromBody] Person person)
        {
            person.Id = getNextId();

            InMemory.persons.Add(person);
        }

        private int getNextId()
        {
            return InMemory.persons.Max(p => p.Id) + 1;
        }
    }
}