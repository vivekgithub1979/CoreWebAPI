using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    [Table("VwVpApproval")]
    public class VwVpApproval
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }
        
        [Display(Name = "Employee Name")]
        [StringLength(50)]
        public string FullName { get; set; }
        
        [Display(Name = "Title")]
        [StringLength(50)]
        public string Title { get; set; }
        
        [Display(Name = "Instance")]
        [Required]
        [StringLength(50)]
        public string InstanceId { get; set; }
        
        [StringLength(50)]
        public string StatusId { get; set; }

        public bool? Approved { get; set; }
        
        public DateTime? ApprovedDate { get; set; }

        [StringLength(50)]
        public string ApprovedByUsername { get; set; }

        [StringLength(50)]
        public string ApprovedByName { get; set; }

        [StringLength(50)]
        public string ApprovedByIpAddress { get; set; }
        
        public DateTime? RejectedDate { get; set; }

        [StringLength(50)]
        public string RejectedByUsername { get; set; }

        [StringLength(50)]
        public string RejectedByName { get; set; }

        [StringLength(50)]
        public string RejectedByIpAddress { get; set; }
        
        public bool Enabled { get; set; }

        public DateTime? LastUpdatedDate { get; set; }

        [StringLength(50)]
        public string LastUpdatedByUsername { get; set; }

        [StringLength(50)]
        public string LastUpdatedByName { get; set; }

        [StringLength(50)]
        public string LastUpdatedByIpAddress { get; set; }
    }
}
