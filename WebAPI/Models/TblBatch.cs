using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebAPI.Models
{
    [Table("TblBatch")]
    public  class TblBatch
    {
        [Display(Name ="Batch ID")]
        public int Id { get; set; }
        
        [StringLength(256)]
        [Display(Name = "Name")]
        public string Name { get; set; }
        
        [Display(Name = "Initial Size")]
        public long? Size { get; set; }

        [Display(Name = "Active")]
        public bool Active { get; set; }

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

        [Display(Name ="Enabled")]
        public bool Enabled { get; set; }

        [Display(Name = "Last Updated Date")]
        public DateTime? LastUpdatedDate { get; set; }

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
        
        [Display(Name = "System")]
        public string System { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<TblUserAccessRequest> TblUserAccessRequest { get; set; } = new HashSet<TblUserAccessRequest>();


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<TblUserHierarchy> TblUserHierarchy { get; set; } = new HashSet<TblUserHierarchy>();
    }
}
