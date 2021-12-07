using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebAPI.Models
{
    [Table("TblApprovedRequest")]
    public class TblApprovedRequest
    {
        public TblApprovedRequest()
        {
            Enabled = true;
        }

        [Display(Name="UAR ID")]
        public long UserAccessRequestId { get; set; }

        [Display(Name = "ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Display(Name = "Approval Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime ApprovedDate { get; set; }

        [Display(Name = "Approved By Username")]
        [StringLength(50)]
        public string ApprovedByUsername { get; set; }

        [Display(Name = "Reviewer")]
        [StringLength(50)]
        public string ApprovedByName { get; set; }

        [Display(Name = "From Ip")]
        [StringLength(50)]
        public string ApprovedByIpAddress { get; set; }

        public long? VpApprovalId { get; set; }

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
        public virtual TblUserAccessRequest TblUserAccessRequest { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        public virtual TblVpApproval TblVpApproval { get; set; }
    }
}
