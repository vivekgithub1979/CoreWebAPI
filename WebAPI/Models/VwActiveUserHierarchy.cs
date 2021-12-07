using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebAPI.Models
{
    [Table("VwActiveUserHierarchy")]
    public class VwActiveUserHierarchy
    {
        [Key]
        [Display(Name = "Employee ID")]
        [StringLength(50)]
        public string UserId { get; set; }
        
        [Display(Name = "Manager ID")]
        [StringLength(50)]
        public string ManagerId { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        public virtual TblUser User { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        public virtual TblUser Manager { get; set; }
    }
}
