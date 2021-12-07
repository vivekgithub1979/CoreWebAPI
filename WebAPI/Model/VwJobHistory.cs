using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI.Model
{
    public partial class VwJobHistory
    {
        public string JobName { get; set; }
        public Guid JobId { get; set; }
        public DateTime? StartDate { get; set; }
        public int RunDuration { get; set; }
    }
}
