using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMS.Domain
{
    public class Employee : BaseEntity
    {
        public long Id { get; set; }

        [DefaultValue(1)]
        public int CompanyId { get; set; }

        [DefaultValue(1)]
        public int LocationID { get; set; }

        [Required]
        [MaxLength(15)]
        public string EmployeeCode { get; set; }

        [Required]
        [MaxLength(15)]
        public string Passcode { get; set; }
      
        [Required]
        [MaxLength(100)]
        public string EmployeeName { get; set; }

        [DefaultValue("")]
        public string Telephone { get; set; }

        [Required]
        public string Mobile { get; set; }
        [DefaultValue(0)]
        public bool IsActive { get; set; }
        [DefaultValue(0)]
        public decimal CreditLimit { get; set; }
        [DefaultValue(0)]
        public decimal CashInHand { get; set; }
        [DefaultValue(0)]
        public decimal BasicMonthlySalary { get; set; }
        [DefaultValue(0)]
        public decimal HorlyRate { get; set; }
        [DefaultValue(0)]
        public decimal OutStanding { get; set; }
        [DefaultValue(0)]
        public decimal Settlement { get; set; }
        [DefaultValue(0)]
        public decimal SpecialHorlyRate { get; set; }
        [DefaultValue(0)]
        public decimal OtRate { get; set; }
        [DefaultValue(0)]
        public decimal SpecialOtRate { get; set; }

        public bool IsPumper { get; set; }

    }
}
