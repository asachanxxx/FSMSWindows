using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMS.Domain
{
    public class DipChart : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DefaultValue(0)]
        public decimal Length { get; set; }
        [Required]
        [DefaultValue(0)]
        public decimal Capacity { get; set; }

    }
}
