using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebAPI.Models
{
    public class TblUserAccessRequest
    {
        public TblUserAccessRequest()
        {
            Enabled = true;
        }

        [Display(Name = "Batch ID")]
        public int BatchId { get; set; }

        [Display(Name = "System ID")]
        [Required]
        [StringLength(50)]
        public string SystemId { get; set; }

        [Display(Name = "Instance")]
        [Required]
        [StringLength(50)]
        public string InstanceId { get; set; }

        [Display(Name = "UAR ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Display(Name = "Employee ID")]
        [Required]
        [StringLength(50)]
        public string UserId { get; set; }

        [Display(Name = "Access")]
        [Required]
        [StringLength(50)]
        public string AccessId { get; set; }

        [Display(Name = "VP Approval Required")]
        public bool VpApprovalRequired { get; set; }

        [Display(Name = "Status")]
        [Required]
        [StringLength(50)]
        public string StatusId { get; set; }

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


    }
}
