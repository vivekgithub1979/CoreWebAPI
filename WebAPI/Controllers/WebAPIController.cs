using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebAPI.Model;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class WebAPIController : Controller
    {
        private readonly UARAuditAppDbContext uarAuditAppDbContext;

        public WebAPIController(UARAuditAppDbContext uarAuditAppDbContext)
        {
            this.uarAuditAppDbContext = uarAuditAppDbContext;
        }
        [HttpGet]
        public IEnumerable<WebApiitem> Get()
        {
            return GetWebAPIItems();
        }
        // GET: api/WebAPIItem/5
        [HttpGet("{id}", Name = "Get")]
        public WebApiitem Get(int id)
        {
            return GetWebAPIItems().Find(e => e.Id == id);
        }
        // POST: api/WebAPIItems
        [HttpPost]
        [Produces("application/json")]
        public WebApiitem Post([FromBody] WebApiitem webAPIItems)
        {

            uarAuditAppDbContext.WebApiitems.AddAsync(webAPIItems);
            uarAuditAppDbContext.SaveChanges();
            // Logic to create new Employee
            return new WebApiitem();
        }
        // PUT: api/Employee/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] WebApiitem webAPIItems)
        {
        }
        // DELETE: api/Employee/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        private List<WebApiitem> GetWebAPIItems()
        {
            return new List<WebApiitem>()
        {
            new WebApiitem()
            {

                Id = 1,
                Name= "John",
                IsComplete = true
            },
            new WebApiitem()
            {
                Id = 2,
                Name= "Jane",
                IsComplete = true
            }
        };
        }
    }
}
