using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI.Model
{
    public partial class VwJobStatus
    {
        public string JobName { get; set; }
        public Guid JobId { get; set; }
        public string Server { get; set; }
        public DateTime? StartDate { get; set; }
        public int? Elapsed { get; set; }
        public DateTime? StopDate { get; set; }
    }
}
