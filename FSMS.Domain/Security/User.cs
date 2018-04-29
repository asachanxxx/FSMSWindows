//**********************************************************************
//Developer  :PUBUDU
//Date       :2013/10/04
//Description:Login Properties
//Module Name: smartOffice
//**********************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FSMS.Domain
{
    public class User
    {
        public string id { get; set; }
        public string strUserName { get; set; }
        public string strPassword { get; set; }
        public bool IsActive { get; set; }
        public int UserRoleId { get; set; }
        public int EmployeeId { get; set; }
        
    }
}
