using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMS.Domain
{
    public class Category : BaseEntity
    {
        public int Id { get; set; }

        [Required]
        public long LocationID { get; set; }

        [Required]
        [MaxLength(15)]
        public string CategoryCode { get; set; }

        [Required]
        [MaxLength(50)]
        public string CategoryName { get; set; }

        [MaxLength(150)]
        [DefaultValue("")]
        public string Remark { get; set; }

        [DefaultValue(0)]
        public bool IsDelete { get; set; }

    }
}
