using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI.Model
{
    public partial class TblStatus
    {
        public TblStatus()
        {
            TblChangeRequests = new HashSet<TblChangeRequest>();
            TblVpApprovals = new HashSet<TblVpApproval>();
        }

        public string Id { get; set; }

        public virtual ICollection<TblChangeRequest> TblChangeRequests { get; set; }
        public virtual ICollection<TblVpApproval> TblVpApprovals { get; set; }
    }
}
