using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    [Table("VwJobHistory")]
    public class VwJobHistory
    {
        [Key]
        [Column(Order = 0)]
        [Display(Name="Job Name")]
        public string JobName { get; set; }

        [Key]
        [Column(Order = 1)]
        [Display(Name = "Job ID")]
        public Guid JobId { get; set; }

        [Key]
        [Column(Order = 2)]
        [Display(Name = "Start Date")]
        public DateTime? StartDate { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Run Duration")]
        public int RunDuration { get; set; }
    }
}
