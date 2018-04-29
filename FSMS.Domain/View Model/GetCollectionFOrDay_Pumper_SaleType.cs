using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMS.Domain
{
    public class GetCollectionFOrDay_Pumper_SaleType
    {

        //CC.Id AS CCID, CCB.Id AS CCBID, DM.Day, E.EmployeeName, 
        //    CC.IsProcessed, V.VehicleName, B.Name AS Bank, 
        //    CCB.CardReferance, CCB.VoucherNO, CCB.Value

        public int CCID { get; set; }
        public decimal CashTotal { get; set; }
        public decimal CardTotal { get; set; }
        public decimal VoucherTotal { get; set; }
        public decimal Expenses { get; set; }
        public decimal Other { get; set; }

        public IEnumerable<GetCollectionFOrDay_Pumper_SaleType_Breakdown> Breaks { get; set; }


    }

    public class GetCollectionFOrDay_Pumper_SaleType_Breakdown
    {

        public int CCID { get; set; }
        public int CCBID { get; set; }
        public string Day { get; set; }
        public string EmployeeName { get; set; }
        public bool IsProcessed { get; set; }
        public string VehicleName { get; set; }
        public string Bank { get; set; }
        public string CardReferance { get; set; }
        public string VoucherNO { get; set; }
        public decimal Value { get; set; }
    }
}
