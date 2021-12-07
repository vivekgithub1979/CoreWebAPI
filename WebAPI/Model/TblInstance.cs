using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI.Model
{
    public partial class TblInstance
    {
        public string SystemId { get; set; }
        public string Id { get; set; }

        public virtual TblSystem System { get; set; }
    }
}
