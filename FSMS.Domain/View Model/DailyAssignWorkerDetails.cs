using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMS.Domain
{
    public class DailyAssignWorkerDetails
    {
        /// </summary>
		public int DayWorkerID { get; set; }

        /// <summary>
        /// Gets or sets the DayID value.
        /// </summary>
        public int DayID { get; set; }

        /// <summary>
        /// Gets or sets the NozzelID value.
        /// </summary>
        public int NozzelID { get; set; }

        /// <summary>
        /// Gets or sets the PumpName value.
        /// </summary>
        public string PumpName { get; set; }

        /// <summary>
        /// Gets or sets the TankId value.
        /// </summary>
        public int TankId { get; set; }

        /// <summary>
        /// Gets or sets the TankName value.
        /// </summary>
        public string TankName { get; set; }

        /// <summary>
        /// Gets or sets the FuelTypeId value.
        /// </summary>
        public int FuelTypeId { get; set; }

        /// <summary>
        /// Gets or sets the FuelFullName value.
        /// </summary>
        public string FuelFullName { get; set; }

        /// <summary>
        /// Gets or sets the NozzelName value.
        /// </summary>
        public string NozzelName { get; set; }

        /// <summary>
        /// Gets or sets the UnitPrice value.
        /// </summary>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// Gets or sets the AssignTime value.
        /// </summary>
        public DateTime AssignTime { get; set; }

        /// <summary>
        /// Gets or sets the IsOpen value.
        /// </summary>
        public bool IsOpen { get; set; }

        /// <summary>
        /// Gets or sets the ClosedTime value.
        /// </summary>
        public DateTime ClosedTime { get; set; }

        /// <summary>
        /// Gets or sets the ClosedBy value.
        /// </summary>
        public int ClosedBy { get; set; }

        /// <summary>
        /// Gets or sets the PumperID value.
        /// </summary>
        public int PumperID { get; set; }

        /// <summary>
        /// Gets or sets the LastTotalizerReading value.
        /// </summary>
        public decimal LastTotalizerReading { get; set; }

        /// <summary>
        /// Gets or sets the EmployeeName value.
        /// </summary>
        public string EmployeeName { get; set; }

        public int SeqNo { get; set; }
    }
}
