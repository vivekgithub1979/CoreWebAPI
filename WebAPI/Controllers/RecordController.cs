using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using WebAPI.Model;


namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecordController : Controller
    {
        private readonly UARAuditAppDbContext webAPIContext;
        public RecordController(UARAuditAppDbContext webAPIContext, IConfiguration configuration)
        {
            this.webAPIContext = webAPIContext;     
        }
        [HttpGet]
        public IActionResult Get()
        {
            var result = GettblUserAccessRequest();
            return Ok(result);
        }
        
        //GET: api/WebAPIItem/5
        [HttpGet("{id}", Name = "GetById")]
        public List<TblUserAccessRequest> GetById(int idVal)
        {
            return GettblUserAccessRequest().Where<TblUserAccessRequest>(e => e.Id == idVal).ToList<TblUserAccessRequest>();
        }
        // POST: api/WebAPIItems
        [HttpPost]
        [Produces("application/json")]
        public TblChangeRequest Post([FromBody] TblChangeRequest TblChangeRequestsItems)
        {

            webAPIContext.TblChangeRequests.AddAsync(TblChangeRequestsItems);
            webAPIContext.SaveChanges();
            // Logic to create new Employee
            return new TblChangeRequest();
        }
        //// PUT: api/Employee/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] WebAPIItems webAPIItems)
        //{
        //}
        //// DELETE: api/Employee/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
        private List<TblUserAccessRequest> GettblUserAccessRequest()
        {
            var x = webAPIContext.TblUserAccessRequests                
                .Where(x => x.Enabled==true)
                .Where(x => x.StatusId == "Not Processed")
                .Where(x => x.SystemId == "Eclipse").Take(100).ToList();

            return x;
        }
    }
}
