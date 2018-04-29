//*************************************************************
//Developer  :Nilmini Paragahawaththage
//Date       :2013/11/28
//Description:u_UserRights properties
//Module Name: smartOffice
//*************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FSMS.Domain
{
    public class UserRightsViewModel
    {
        public int Role { get; set; }
        public int UserId { get; set; }
        public int MenuTag { get; set; }
        public string MenuRights { get; set; }
        public string MenuName { get; set; }
        public string MenuTagCode{ get; set; }


    }
}
