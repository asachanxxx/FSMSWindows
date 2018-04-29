using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMS.Domain
{
    public class Supplier : BaseEntity
    {
        public int Id { get; set; }

        [Required]
        [DefaultValue("")]
        [MaxLength(15)]
        public string SupplierCode { get; set; }

        [Required]
        [DefaultValue(0)]
        public int SupplierTitle { get; set; }

        [Required]
        [DefaultValue("")]
        [MaxLength(100)]
        public string SupplierName { get; set; }

        [Required]
        [DefaultValue(0)]
        public int SupplierType { get; set; }

        [DefaultValue("")]
        [MaxLength(100)]
        public string ContactPersonName { get; set; }

        [DefaultValue("")]
        [MaxLength(100)]
        public string Email { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string RepresentativeName { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        public string RepresentativeNICNo { get; set; }

        public string SupplierImage { get; set; }

        [DefaultValue(" ")]
        [MaxLength(20)]
        public string PostalCode { get; set; }

        [DefaultValue(0)]
        public int TaxID1 { get; set; }

        [DefaultValue(0)]
        public int PaymentMethod { get; set; }

        [DefaultValue(0)]
        public decimal CreditLimit { get; set; }

        [DefaultValue(0)]
        public decimal ChequeLimit { get; set; }

        [DefaultValue(0)]
        public int PaymentTermID { get; set; }

        [DefaultValue(0)]
        public int CreditPeriod { get; set; }

        [DefaultValue("")]
        [MaxLength(100)]
        public string Remark { get; set; }

        [DefaultValue(0)]
        public bool IsBlocked { get; set; } // not allow to do transactions, view only

        [DefaultValue(0)]
        public bool IsSuspended { get; set; } // not allow to do transactions, view only

    }
}
