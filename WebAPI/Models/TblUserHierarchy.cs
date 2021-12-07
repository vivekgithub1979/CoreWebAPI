using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebAPI.Models
{
    [Table("TblUserHierarchy")]
    public class TblUserHierarchy
    {
        [Key, Column(Order=0)]
        [Display(Name = "Batch ID")]
        public int BatchId { get; set; }

        [Key, Column(Order = 1)]
        [Display(Name = "Employee ID")]
        [StringLength(50)]
        public string UserId { get; set; }
        
        [Display(Name = "Manager ID")]
        [StringLength(50)]
        public string ManagerId { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        public virtual TblBatch TblBatch { get; set; }
        
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual TblUser User { get; set; } 
        
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual TblUser Manager { get; set; }
    }
}
