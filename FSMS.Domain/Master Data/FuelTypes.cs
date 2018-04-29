using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FSMS.Domain
{
    public class FuelType : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string FuelFullName { get; set; }
        [Required]
        [MaxLength(20)]
        public string FuelShortName { get; set; }
        [DefaultValue(0)]
        [Required]
        public decimal UnitPrice { get; set; }


    }
}