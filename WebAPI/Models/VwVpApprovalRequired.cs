using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebAPI.Models
{
    [Table("VwVpApprovalRequired")]
    public class VwVpApprovalRequired
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BatchId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TrafficId { get; set; }

        public bool TrafficApproved { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SalesId { get; set; }

        public bool SalesApproved { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        public virtual TblUserAccessRequest Traffic { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        public virtual TblUserAccessRequest Sales { get; set; }
    }
}