using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    [Table("VwAuditKpi")]
    public class VwAuditKpi
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Id { get; set; }

        [StringLength(50)]
        public string FullName { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string SystemId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int QuantityApproved { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int QuantityChanged { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int QuantityPending { get; set; }
    }
}
