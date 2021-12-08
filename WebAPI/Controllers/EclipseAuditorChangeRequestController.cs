using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using WebAPI.Model;


namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EclipseAuditorChangeRequestController : Controller
    {
        private readonly UARAuditAppDbContext webAPIContext;
        public EclipseAuditorChangeRequestController(UARAuditAppDbContext webAPIContext, IConfiguration configuration)
        {
            this.webAPIContext = webAPIContext;
        }

        [HttpGet]
        [EnableCors("AllowOrigin")]
        public IActionResult Get()
        {
            var result = getEclipseAuditorChangeRequests();
            return Ok(result);
        }
        private List<TblChangeRequest> getEclipseAuditorChangeRequests() {
            var changeRequests = webAPIContext.TblChangeRequests.Where(x => x.StatusId == "Reassigned").Take(100).ToList();
        //    var status = StatusUtility.GetReassignedStatus();
        //    var reassigned = _service.GetReassignedChangeRequests()
        //       .Include(x => x.TblUserAccessRequest)
        //       .Include(x => x.TblUserAccessRequest.TblUser);

            //var data = _service.GetNotProcessedChangeRequests()
            //    .Include(x => x.TblUserAccessRequest)
            //    .Include(x => x.TblUserAccessRequest.TblUser)
            //    .Concat(reassigned);

            return changeRequests;

        }
    }
}
