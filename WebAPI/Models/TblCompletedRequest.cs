using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebAPI.Models
{
    [Table("TblCompletedRequest")]
    public class TblCompletedRequest
    {
        public TblCompletedRequest()
        {
            Enabled = true;
        }

        [Display(Name = "Change Request ID")]
        public long ChangeRequestId { get; set; }

        [Display(Name = "ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Display(Name = "Evidence Url")]
        [StringLength(1024)]
        public string Url { get; set; }

        [Display(Name = "Evidence")]
        [StringLength(1024)]
        public string Evidence { get; set; }

        [Display(Name = "Submitted Date")]
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime CorrectionDate { get; set; }

        [Display(Name = "Completed Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime CompletedDate { get; set; }

        [Display(Name = "Completed By Username")]
        [StringLength(50)]
        public string CompletedByUsername { get; set; }

        [Display(Name = "Completed By User")]
        [StringLength(50)]
        public string CompletedByName { get; set; }

        [Display(Name = "Completed By Ip")]
        [StringLength(50)]
        public string CompletedByIpAddress { get; set; }

        [Display(Name = "Enabled")]
        public bool Enabled { get; set; }

        [Display(Name = "Last Updated Date")]
        public DateTime LastUpdatedDate { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Last Updated By Username")]
        public string LastUpdatedByUsername { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Last Updated By Name")]
        public string LastUpdatedByName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Last Updated From Ip.")]
        public string LastUpdatedByIpAddress { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        public virtual TblChangeRequest TblChangeRequest { get; set; }
    }
}
