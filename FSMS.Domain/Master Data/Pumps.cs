using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FSMS.Domain
{
    public class Pump : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        [DefaultValue(1)]
        [Required]
        public int NoofNozzels { get; set; }
        [Required]
        [MaxLength(20)]
        public string PumpName { get; set; }
        [DefaultValue(0)]
        [Required]
        public int PumpOrderNo { get; set; }

    }
}