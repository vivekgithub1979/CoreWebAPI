using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI.Model
{
    public partial class WebApiitem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
