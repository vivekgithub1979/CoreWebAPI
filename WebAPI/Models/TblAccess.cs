using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebAPI.Models
{

    [Table("TblAccess")]
    public class TblAccess
    {
        [Required]
        [StringLength(50)]
        public string SystemId { get; set; }

        [StringLength(50)]
        public string Id { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        public virtual TblSystem TblSystem { get; set; }
    }
}
