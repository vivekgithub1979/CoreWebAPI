using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    [Table("VwAuditKpiByUser")]
    public class VwAuditKpiByUser
    {
        [StringLength(50)]
        public string Id { get; set; }

        [StringLength(50)]
        public string FullName { get; set; }

        public int? TotalQuantityApproved { get; set; }

        public int? TotalQuantityChanged { get; set; }

        public int? TotalQuantityPending { get; set; }
    }
}
