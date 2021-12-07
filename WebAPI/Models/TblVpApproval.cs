using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    [Table("TblVpApproval")]
    public class TblVpApproval
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblVpApproval()
        {
            TblApprovedRequests = new HashSet<TblApprovedRequest>();
        }

        public long Id { get; set; }

        [Required]
        [StringLength(50)]
        public string StatusId { get; set; }

        public bool? Approved { get; set; }

        public DateTime? ApprovedDate { get; set; }

        [StringLength(50)]
        public string ApprovedByUsername { get; set; }

        [StringLength(50)]
        public string ApprovedByName { get; set; }

        [StringLength(50)]
        public string ApprovedByIpAddress { get; set; }

        public DateTime? RejectedDate { get; set; }

        [StringLength(50)]
        public string RejectedByUsername { get; set; }

        [StringLength(50)]
        public string RejectedByName { get; set; }

        [StringLength(50)]
        public string RejectedByIpAddress { get; set; }

        public bool Enabled { get; set; }

        public DateTime? LastUpdatedDate { get; set; }

        [StringLength(50)]
        public string LastUpdatedByUsername { get; set; }

        [StringLength(50)]
        public string LastUpdatedByName { get; set; }

        [StringLength(50)]
        public string LastUpdatedByIpAddress { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblApprovedRequest> TblApprovedRequests { get; set; }
    }
}
