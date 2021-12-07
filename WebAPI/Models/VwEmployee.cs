using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    [Table("VwEmployee")]
    public class VwEmployee
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string Pid { get; set; }

        [Key]
        [Column(Order = 1)]
        [Display(Name = "Employee Name")]
        public string Name { get; set; }

        [Key]
        [Column(Order = 2)]
        [Display(Name = "Legacy Name")]
        public string SamAccountName { get; set; }
    }
}
