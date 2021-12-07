using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Models
{
    public class WebAPIContext: DbContext
    {
        public WebAPIContext(DbContextOptions<WebAPIContext> options)
            : base(options)
        {

        }

        public virtual DbSet<TblAccess> TblAccess { get; set; }
        public virtual DbSet<TblApprovedRequest> TblApprovedRequest { get; set; }
        public virtual DbSet<TblAnnouncement> TblAnnouncement { get; set; }
        public virtual DbSet<TblBatch> TblBatch { get; set; }
        public virtual DbSet<TblChangeRequest> TblChangeRequest { get; set; }
        public virtual DbSet<TblCompletedRequest> TblCompletedRequest { get; set; }
        public virtual DbSet<TblChangeRequestType> TblChangeRequestTypes { get; set; }
        public virtual DbSet<TblInstance> TblInstance { get; set; }
        public virtual DbSet<TblStatus> TblStatus { get; set; }
        public virtual DbSet<TblSystem> TblSystem { get; set; }
        public virtual DbSet<TblUser> TblUser { get; set; }
        public virtual DbSet<TblUserHierarchy> TblUserHierarchy { get; set; }
        public virtual DbSet<TblUserAccessRequest> TblUserAccessRequest { get; set; }
        public virtual DbSet<TblVpApproval> TblVpApproval { get; set; }

        //public virtual DbSet<VwJobHistory> VwJobHistory { get; set; }
        //public virtual DbSet<VwJobStatus> VwJobStatus { get; set; }

        //public virtual DbSet<VwAuditKpi> VwAuditKpi { get; set; }
        //public virtual DbSet<VwAuditKpiBySystem> VwAuditKpiBySystem { get; set; }
        //public virtual DbSet<VwAuditKpiByUser> VwAuditKpiByUser { get; set; }
        //public virtual DbSet<VwVpApproval> VwVpApproval { get; set; }
        //public virtual DbSet<VwVpApprovalRequired> VwVpApprovalRequired { get; set; }
        //public virtual DbSet<VwEmployee> VwEmployee { get; set; }

        public virtual DbSet<WebAPIItems> WebAPIItems { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblUserHierarchy>()
                .HasKey(o => o.UserId);
        }
    }


}
