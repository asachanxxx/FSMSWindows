using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMS.Domain
{
    public class ProductMaster : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(25)]
        public string ProductCode { get; set; }

        [MaxLength(25)]
        public string BarCode { get; set; }

        [MaxLength(25)]
        public string ReferenceCode1 { get; set; }

        [MaxLength(25)]
        public string ReferenceCode2 { get; set; }

        [Required]
        [MaxLength(150)]
        public string ProductName { get; set; }

        [Required]
        [MaxLength(150)]
        public string NameOnInvoice { get; set; }

        [Required]
        public int CategoryID { get; set; }

        [Required]
        public int SubCategoryID { get; set; }

        [Required]
        public int SupplierID { get; set; }

        [Required]
        public int UnitOfMeasureID { get; set; }

        [Required]
        [MaxLength(25)]
        public string PackSize { get; set; }

        public string ProductImage { get; set; }

      
        [DefaultValue(0)]
        [Required]
        public decimal CostPrice { get; set; }

        [DefaultValue(0)]
        [Required]
        public decimal AverageCost { get; set; }

        [DefaultValue(0)]
        [Required]
        public decimal SellingPrice { get; set; }

        [DefaultValue(0)]
        [Required]
        public decimal WholesalePrice { get; set; }

        [DefaultValue(0)]
        [Required]
        public decimal FixedDiscount { get; set; }

        [DefaultValue(0)]
        [Required]
        public decimal MaximumDiscount { get; set; }

        [DefaultValue(0)]
        [Required]
        public decimal ReOrderLevel { get; set; }

        [DefaultValue(0)]
        [Required]
        public decimal ReOrderQty { get; set; }

        [DefaultValue(0)]
        [Required]
        public decimal ReOrderPeriod { get; set; }

        [DefaultValue(0)]
        public bool IsActive { get; set; }

        [DefaultValue(0)]
        public bool IsExpiry { get; set; }

        [DefaultValue(0)]
        public bool IsCountable { get; set; }

        [DefaultValue(0)]
        public bool IsTax { get; set; }

        [DefaultValue(0)]
        public bool IsNonExchangeable { get; set; }

        [MaxLength(150)]
        [DefaultValue("")]
        public string Remark { get; set; }

        [DefaultValue(0)]
        public decimal WeightPerUnit { get; set; }

    }
}
