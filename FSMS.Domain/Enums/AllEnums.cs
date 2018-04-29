using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMS.Domain
{
    public enum CustomerStatus
    {
        Active = 1,
        Suspended =2,
        BackListed = 2
    }

    public enum VehicleStatus
    {
        Active = 1,
        Suspended = 2,
        BackListed = 2
    }

    public enum DatProgressStatus
    {
        Start = 1,
        End = 2,
    }
    public enum SaleHedStatus
    {
        Pending = 1,
        Confirmed = 2,
        Cancelled = 3
    }
}
