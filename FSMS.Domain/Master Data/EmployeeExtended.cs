using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FSMS.Domain
{
    public class EmployeeExtended : BaseEntity
    {
        public int Id { get; set; }

        public int EmployeeID { get; set; }

        [Required]
        [MaxLength(15)]
        public string EmployeeTitle { get; set; }

        [DefaultValue("")]
        public string Email { get; set; }

        [Required]
        [MaxLength(100)]
        public string Address1 { get; set; }

        [Required]
        [MaxLength(100)]
        public string Address2 { get; set; }

        [DefaultValue("")]
        [MaxLength(100)]
        public string Address3 { get; set; }

        [MaxLength(100)]
        public string Designation { get; set; }

        [Required]
        [DefaultValue(0)]
        public int Gender { get; set; }

        public string ImageURL { get; set; }

        [DefaultValue(0)]
        public int Rank { get; set; }

        [DefaultValue("")]
        [MaxLength(100)]
        public string Remark { get; set; }

        public DateTime DOB { get; set; }

        public DateTime EmployeeStartDate { get; set; }


    }
}