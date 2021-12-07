using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    [Table("VwAuditKpiBySystem")]
    public class VwAuditKpiBySystem
    {
        [Key]
        [StringLength(50)]
        public string SystemId { get; set; }

        public int? TotalQuantityApproved { get; set; }

        public int? TotalQuantityChanged { get; set; }

        public int? TotalQuantityPending { get; set; }
    }
}
