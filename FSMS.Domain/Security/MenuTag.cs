//*************************************************************
//Developer  :Nilmini Paragahawaththage
//Date       :2013/11/01
//Description:Properties of menu tag
//Module Name: smartOffice
//*************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FSMS.Domain
{
    public class MenuTag
    {
        public string Id { get; set; }
        public string strDescription { get; set; }
        public string strMenuRights { get; set; }
        public int intMainOrder { get; set; }
        public int intSubOrder { get; set; }
        public string MenuTagCode { get; set; }
    }
}
