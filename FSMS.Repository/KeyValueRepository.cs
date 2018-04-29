using Dapper;
using FSMS.Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMS.Repository
{
    public class KeyValueRepository
    {
        private static string _connectionName;
        private string _tablename;

        public KeyValueRepository()
        {

        }



        public static IEnumerable<KeyValue> GetNozzels()
        {

            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    return db.Query<KeyValue>(" select id, NozzelName as Name from Nozzles");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static IEnumerable<KeyValue> GetPumpers()
        {

            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    return db.Query<KeyValue>("  select id, EmployeeName as Name from Employees where ispumper = 1");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static IEnumerable<KeyValue> GetBanks()
        {

            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    return db.Query<KeyValue>("select id,  Name from banks order by name Asc");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static IEnumerable<KeyValue> GetShifts()
        {

            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    return db.Query<KeyValue>(" select id, shifname as Name from Shifts");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static IEnumerable<KeyValue> GetDays()
        {

            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    return db.Query<KeyValue>("select id,Day  as Name from DayMasters  where iscompleted=0");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static IEnumerable<KeyValue> GetSalesType()
        {
            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    return db.Query<KeyValue>("select id,Code as Name from SalesTypes order by Code");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static IEnumerable<KeyValue> GetFuelTypes()
        {

            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    return db.Query<KeyValue>("select id,FuelShortName as Name from FuelTypes order by FuelShortName");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static IEnumerable<KeyValue> GetTanks()
        {

            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    return db.Query<KeyValue>("select id, TankName as Name from tanks order by TankName");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static IEnumerable<KeyValue> GetVehicles()
        {

            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    return db.Query<KeyValue>("select id,VehicleName as Name from Vehicles order by Name asc");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
