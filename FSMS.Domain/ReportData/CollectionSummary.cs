using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMS.Domain.ReportData
{
   
        public class CollectionSummary
        {
            public int Id { get; set; } //(int, not null)
            public int DayId { get; set; } //(int, not null)
            public string Day { get; set; } //(nvarchar(max), null)
            public int PumperId { get; set; } //(int, not null)
            public decimal Value { get; set; } //(decimal(18,2), not null)
            public decimal SystemValue { get; set; } //(decimal(18,2), not null)
            public int VehicleID { get; set; } //(int, not null)
            public string VehicleName { get; set; } //(nvarchar(50), not null)
            public int SaleId { get; set; } //(int, not null)
            public string Name { get; set; } //(nvarchar(max), null)
            public string CardReferance { get; set; } //(nvarchar(max), null)
            public string VoucherNO { get; set; } //(nvarchar(max), null)
            public bool Iscancel { get; set; } //(bit, not null)
            public DateTime CencelledDate { get; set; } //(datetime, not null)
            public int CancelledUserId { get; set; } //(int, not null)
            public int BankId { get; set; } //(int, not null)
            public string Expr1 { get; set; } //(nvarchar(max), null)
            public string EmployeeName { get; set; } //(nvarchar(100), not null)
            public int SessionId { get; set; } //(int, not null)
            public int ColelctionDate { get; set; } //(int, not null)
        }

    }

