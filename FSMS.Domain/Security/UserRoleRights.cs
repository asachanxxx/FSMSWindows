//*************************************************************
//Developer  :Nilmini Paragahawaththage
//Date       :2013/11/01
//Description:u_UserRoleRights properties
//Module Name: smartOffice
//*************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FSMS.Domain
{
    public class UserRoleRights
    {
        public UserRole Role { get; set; }
        public MenuTag MenuTag { get; set; }
        public string strMenuRights { get; set; }
    }
}
