using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public class VwJobStatus
    {
        [Key]
        [Column(Order = 0)]
        [Display(Name = "Job Name")]
        public string JobName { get; set; }

        [Key]
        [Column(Order = 1)]
        [Display(Name = "Job ID")]
        public Guid JobId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(128)]
        [Display(Name = "Server")]
        public string Server { get; set; }

        [Display(Name = "Start Date")]
        public DateTime? StartDate { get; set; }

        [Display(Name = "Run Duration")]
        public int? Elapsed { get; set; }
        
        [Display(Name = "Stop Date")]
        public DateTime? StopDate { get; set; }
    }
}
