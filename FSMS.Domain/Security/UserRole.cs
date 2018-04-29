//**********************************************************************
//Developer  :PUBUDU
//Date       :2013/10/04
//Description:User Role Properties
//Module Name: smartOffice
//**********************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FSMS.Domain
{
    public class UserRole
    {
        public int Id { get; set; }
        public string strDescription { get; set; }
        public int UserID { get; set; }
        public int intActivate { get; set; }

    }
}
