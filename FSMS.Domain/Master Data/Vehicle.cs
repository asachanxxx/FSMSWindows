using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMS.Domain
{
    public class Vehicle : BaseEntity
    {
        public long Id { get; set; }

        [DefaultValue(0)]
        public int CreditCusId { get; set; }

        [DefaultValue(0)]
        public int RFID_Id { get; set; }

        [DefaultValue(0)]
        public decimal CreditLimit { get; set; }
        [DefaultValue(0)]
        public decimal CreditAlertLimit { get; set; }

        [DefaultValue(0)]
        public decimal ChequeLimit { get; set; }

        [DefaultValue(0)]
        public decimal Outstanding { get; set; }

        public int VehicleStatus { get; set; }

        [DefaultValue("")]
        [MaxLength(50)]
        [Required]
        public string RFIDNo { get; set; }

        [DefaultValue("")]
        [MaxLength(50)]
        [Required]
        public string RegistrationNo { get; set; }

        [DefaultValue("")]
        [MaxLength(50)]
        [Required]
        public string VehicleName { get; set; }

        [DefaultValue("")]
        [MaxLength(50)]
        public string EngineNo { get; set; }

        [DefaultValue("")]
        [MaxLength(50)]
        public string ChassesNo { get; set; }

        [DefaultValue("")]
        [MaxLength(50)]
        public string VehicleType { get; set; }

        [DefaultValue("")]
        [MaxLength(25)]
        [Required]
        public string FuelType { get; set; }

        [DefaultValue("")]
        [MaxLength(50)]
        public string Make { get; set; }

        [DefaultValue("")]
        [MaxLength(50)]
        public string Model { get; set; }

        [DefaultValue("")]
        public string EngineCapacity { get; set; }

        [DefaultValue(0)]
        public int Weight { get; set; }

        [DefaultValue("")]
        [MaxLength(150)]
        public string Remark { get; set; }

        public string VehicleImage { get; set; }
        public int Ratings { get; set; }

    }
}
