using Dapper;
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
    public class CheckExistingRepository
    {
        private static string _connectionName;
        private string _tablename;

        public CheckExistingRepository()
        {
           
        }

        public static bool CheckForExistingSalesType(string typeCode) {
            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    return db.QuerySingleOrDefault<bool>("select id from SalesTypes where Code = '" + typeCode.Trim() + "'");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static bool CheckForExistingFuelType(string typeCode)
        {
            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    return db.QuerySingleOrDefault<bool>("select id from FuelTypes where FuelShortName = '" + typeCode.Trim() + "'");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
