using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI.Model
{
    public partial class TblAccess
    {
        public TblAccess()
        {
            TblChangeRequests = new HashSet<TblChangeRequest>();
        }

        public string SystemId { get; set; }
        public string Id { get; set; }

        public virtual TblSystem System { get; set; }
        public virtual ICollection<TblChangeRequest> TblChangeRequests { get; set; }
    }
}
