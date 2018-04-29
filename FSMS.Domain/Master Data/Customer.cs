using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMS.Domain
{
    public class Customer : BaseEntity
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(15)]
        public string CustomerCode { get; set; }

        [Required]
        [DefaultValue(0)]
        public int CustomerTitle { get; set; }

        [Required]
        [MaxLength(100)]
        public string CustomerName { get; set; }

        /// <summary>
        /// IF -1 NOrmal Customer  2 - Credit Customer
        /// </summary>
        [Required]
        [DefaultValue(0)]
        public int CustomerType { get; set; }


        [MaxLength(100)]
        [DefaultValue("")]
        public string TPno { get; set; }


        [MaxLength(100)]
        [DefaultValue("")]
        public string ContactPersonName { get; set; }

        [Required]
        [DefaultValue(0)]
        public int Gender { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        public string Address1 { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        public string Address2 { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        public string Address3 { get; set; }

        [DefaultValue("")]
        public string Email { get; set; }

        [DefaultValue(0)]
        public decimal CreditLimit { get; set; }
        [DefaultValue(0)]
        public decimal Outstanding { get; set; }
        [DefaultValue(0)]
        public decimal OutstandingAlertLimit { get; set; }
        [DefaultValue(0)]
        public decimal ChequeLimit { get; set; }
        [DefaultValue(0)]
        public decimal ChequeBalance { get; set; }
        [DefaultValue(0)]
        public int Rating { get; set; }
        public string CustomerImage { get; set; }
        [MaxLength(150)]
        [DefaultValue("")]
        public string Remark { get; set; }
        public int CustomerStatus { get; set; }
        [DefaultValue(0)]
        public bool IsCreditAllowed { get; set; }

    }
}
