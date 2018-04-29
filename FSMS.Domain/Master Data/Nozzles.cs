using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FSMS.Domain
{
    public class Nozzle : BaseEntity
    {

        [Key]
        public int Id { get; set; }
        [DefaultValue(0)]
        [Required]
        public int PumpId { get; set; }
        [DefaultValue(0)]
        [Required]
        public int TankId { get; set; }
        [DefaultValue(0)]
        [Required]
        public int FuelTypeId { get; set; }
        public string NozzelName { get; set; }
        [DefaultValue(0)]
        [Required]
        public decimal UnitPrice { get; set; }
        [DefaultValue(0)]
        [Required]
        public decimal LastTotalizerReading { get; set; }

    }
}





