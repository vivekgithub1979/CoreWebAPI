using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebAPI.Models
{
    [Table("TblChangeRequestType")]
    public class TblChangeRequestType
    {
        [Key]
        [Required]
        [StringLength(50)]
        public string Id { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<TblChangeRequest> TblChangeRequests { get; set; } = new HashSet<TblChangeRequest>();
    }
}
