using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FSMS.Domain
{
    public class Shift : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ShifName { get; set; }
        [Required]
        public int StartH { get; set; }
        [Required]
        public int StartM{ get; set; }
        [Required]
        public int EndH { get; set; }
        [Required]
        public int EndM { get; set; }
        [DefaultValue(0)]
        public decimal ShiftLength { get; set; }
        [DefaultValue(0)]
        public decimal BreakLength { get; set; }

      
    }
}