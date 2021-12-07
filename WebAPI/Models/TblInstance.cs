using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebAPI.Models
{
    [Table("TblInstance")]
    public class TblInstance
    {
        [Required]
        [StringLength(50)]
        public string SystemId { get; set; }

        [StringLength(50)]
        public string Id { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        public virtual TblSystem TblSystem { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<TblUserAccessRequest> TblUserAccessRequest { get; set; } = new HashSet<TblUserAccessRequest>();
    }
}
