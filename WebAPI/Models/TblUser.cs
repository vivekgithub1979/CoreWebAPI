using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebAPI.Models
{
    [Table("TblUser")]
    public class TblUser
    {
        [Display(Name = "Employee ID")]
        [StringLength(50)]
        public string Id { get; set; }

        [Display(Name = "Employee Name")]
        [StringLength(50)]
        public string FullName { get; set; }

        [Display(Name = "Title")]
        [StringLength(50)]
        public string Title { get; set; }



        //[SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //[JsonIgnore]
        //public virtual ICollection<VwActiveUserHierarchy> Managers { get; set; }

        //[JsonIgnore]
        //public virtual VwActiveUserHierarchy User { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<TblUserAccessRequest> TblUserAccessRequest { get; set; } = new HashSet<TblUserAccessRequest>();
    }
}
