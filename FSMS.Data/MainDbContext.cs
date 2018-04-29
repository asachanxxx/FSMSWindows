using FSMS.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMS.Data
{
    public class MainDbContext:DbContext
    {
        public MainDbContext():base ("ConnFSMS")
        {

        }

        public DbSet<Category> Category { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<EmployeeExtended> EmployeeExtended { get; set; }
        public DbSet<FuelType> FuelTypes { get; set; }
        public DbSet<Nozzle> Nozzles { get; set; }
        public DbSet<Pump> Pumps { get; set; }
        public DbSet<RfCardMaster> RfCardMaster { get; set; }
        public DbSet<SalesType> SalesType { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<Tank> Tanks { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }
        public DbSet<Banks> Banks { get; set; }
        

        public DbSet<DayMaster> DayMaster { get; set; }
        public DbSet<DaySaleHed> DaySaleHed { get; set; }
        public DbSet<DaySaleDet> DaySaleDet { get; set; }
        public DbSet<Roster> Roster { get; set; }

        public DbSet<User> User { get; set; }
        public DbSet<UserRole> UserRole { get; set; }
        public DbSet<MenuTag> MenuTag { get; set; }
        public DbSet<SysSetup> SysSetup { get; set; }
        public DbSet<UserRights> UserRights { get; set; }

        public DbSet<TotalizeReading> TotalizeReading { get; set; }


        public DbSet<DayAssignWorkers> DayAssignWorkers { get; set; }
        public DbSet<CashCollection> CashCollection { get; set; }
        public DbSet<CashCollectionBreak> CashCollectionBreak { get; set; }
        public DbSet<PumpClosing> PumpClosing { get; set; }

        public DbSet<SystemLog> SystemLog { get; set; }

    }
}
