using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI.Model
{
    public partial class TblSystem
    {
        public TblSystem()
        {
            TblAccesses = new HashSet<TblAccess>();
            TblInstances = new HashSet<TblInstance>();
        }

        public string Id { get; set; }

        public virtual ICollection<TblAccess> TblAccesses { get; set; }
        public virtual ICollection<TblInstance> TblInstances { get; set; }
    }
}
