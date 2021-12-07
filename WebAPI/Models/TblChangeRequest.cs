using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebAPI.Models
{
    [Table("TblChangeRequest")]
    public class TblChangeRequest
    {
        public TblChangeRequest()
        {
            Enabled = true;
        }

        [Display(Name ="UAR ID")]
        public long UserAccessRequestId { get; set; }

        [Display(Name = "ID")]
        [DatabaseGenerated( DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Display(Name = "New Supervisor")]
        [StringLength(50)]
        public string DestinationSupervisor { get; set; }

        [Display(Name = "Dest. Access")]
        [StringLength(50)]
        public string DestinationAccessId { get; set; }

        [Display(Name = "Status")]
        [Required]
        [StringLength(50)]
        public string StatusId { get; set; }

        [Display(Name = "Request Type")]
        [Required]
        [StringLength(50)]
        public string RequestTypeId { get; set; }

        [Display(Name = "Request Date")]
        public DateTime RequestDate { get; set; }

        [Display(Name = "Requested By Username")]
        [StringLength(50)]
        public string RequestByUsername { get; set; }

        [Display(Name = "Requested By User")]
        [StringLength(50)]
        public string RequestByName { get; set; }

        [Display(Name = "Requested By Ip")]
        [StringLength(50)]
        public string RequestByIpAddress { get; set; }

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
