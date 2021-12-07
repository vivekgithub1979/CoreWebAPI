using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI.Model
{
    public partial class VwVpApprovalRequired
    {
        public int BatchId { get; set; }
        public long TrafficId { get; set; }
        public bool TrafficApproved { get; set; }
        public long SalesId { get; set; }
        public bool SalesApproved { get; set; }
    }
}
