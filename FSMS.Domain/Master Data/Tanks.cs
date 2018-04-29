using System.ComponentModel;

namespace FSMS.Domain
{
    public class Tank : BaseEntity
    {
        [DefaultValue(0)]
        public int Id { get; set; }
        [DefaultValue(0)]
        public int FuelTypeID { get; set; }
        public string TankName { get; set; }
        [DefaultValue(0)]
        public decimal InnerDiameter { get; set; }
        [DefaultValue(0)]
        public decimal Length { get; set; }
        [DefaultValue(0)]
        public decimal Capacity { get; set; }
        [DefaultValue(0)]
        public decimal CurrentSIH { get; set; }
    }
}