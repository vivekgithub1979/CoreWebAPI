﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI.Model
{
    public partial class VwVpApproval
    {
        public long Id { get; set; }
        public string FullName { get; set; }
        public string Title { get; set; }
        public string InstanceId { get; set; }
        public string StatusId { get; set; }
        public bool? Approved { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string ApprovedByUsername { get; set; }
        public string ApprovedByName { get; set; }
        public string ApprovedByIpAddress { get; set; }
        public DateTime? RejectedDate { get; set; }
        public string RejectedByUsername { get; set; }
        public string RejectedByName { get; set; }
        public string RejectedByIpAddress { get; set; }
        public bool Enabled { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public string LastUpdatedByUsername { get; set; }
        public string LastUpdatedByName { get; set; }
        public string LastUpdatedByIpAddress { get; set; }
    }
}
