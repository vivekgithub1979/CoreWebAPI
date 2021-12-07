using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    [Table("TblAnnouncement")]
    public class TblAnnouncement
    {
        [Display(Name = "Announcement ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(256)]
        [Display(Name = "Title")]
        [Required]
        public string Title { get; set; }

        [StringLength(1024)]
        [Display(Name = "Message")]
        [Required]
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }

        [Display(Name = "Create Date")]
        public DateTime CreateDate { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Created By Username")]
        public string CreatedByUsername { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Created By User")]
        public string CreatedByName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Created From Ip.")]
        public string CreatedByIpAddress { get; set; }

        [Display(Name = "Enabled")]
        public bool Enabled { get; set; }

        [Display(Name = "Last Updated Date")]
        public DateTime? LastUpdatedDate { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Last Updated By Username")]
        public string LastUpdatedByUsername { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Last Updated By User")]
        public string LastUpdatedByName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Last Updated From Ip.")]
        public string LastUpdatedByIpAddress { get; set; }
    }
}
