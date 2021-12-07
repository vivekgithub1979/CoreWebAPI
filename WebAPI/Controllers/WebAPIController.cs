using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class WebAPIController : Controller
    {
        private readonly WebAPIContext webAPIContext;

        public WebAPIController(WebAPIContext webAPIContext)
        {
            this.webAPIContext = webAPIContext;
        }
        [HttpGet]
        public IEnumerable<WebAPIItems> Get()
        {
            return GetWebAPIItems();
        }
        // GET: api/WebAPIItem/5
        [HttpGet("{id}", Name = "Get")]
        public WebAPIItems Get(int id)
        {
            return GetWebAPIItems().Find(e => e.Id == id);
        }
        // POST: api/WebAPIItems
        [HttpPost]
        [Produces("application/json")]
        public WebAPIItems Post([FromBody] WebAPIItems webAPIItems)
        {

            webAPIContext.WebAPIItems.AddAsync(webAPIItems);
            webAPIContext.SaveChanges();
            // Logic to create new Employee
            return new WebAPIItems();
        }
        // PUT: api/Employee/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] WebAPIItems webAPIItems)
        {
        }
        // DELETE: api/Employee/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        private List<WebAPIItems> GetWebAPIItems()
        {
            return new List<WebAPIItems>()
        {
            new WebAPIItems()
            {

                Id = 1,
                Name= "John",
                IsComplete = true
            },
            new WebAPIItems()
            {
                Id = 2,
                Name= "Jane",
                IsComplete = true
            }
        };
        }
    }
}
