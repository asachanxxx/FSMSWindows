using FSMS.Common;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FSMS.Domain
{
    public class BaseEntity 
    {

        public BaseEntity()
        {
            
            GroupOfCompanyID = LoggedDetails.GroupOfCompanyID;
            CreatedUser = LoggedDetails.LoggedUserId;
            CreatedDate = DateTime.Now;
            ModifiedUser = LoggedDetails.LoggedUserId;
            ModifiedDate = DateTime.Now;
            DataTransfer = 0;
        }

        public int GroupOfCompanyID { get; set; }

        public int CreatedUser { get; set; }

        public DateTime CreatedDate { get; set; }

        
        public int ModifiedUser { get; set; }

        public DateTime ModifiedDate { get; set; }

        [DefaultValue(0)]
        public int DataTransfer { get; set; }

    }
}
