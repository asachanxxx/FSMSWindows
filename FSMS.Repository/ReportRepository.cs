using CrystalDecisions.Shared;
using Dapper;
using FSMS.Domain.ReportData;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FSMS.Repository
{
    public class ReportRepository
    {

        private static string _connectionName;

        public static ParameterFields AddCrystalParamsWithLoca(string reportTitle, string loginuser, string loca, string locaname, string cmpanyname, string Address)
        {

            ParameterField paramField = new ParameterField();
            ParameterFields paramFields = new ParameterFields();
            ParameterDiscreteValue paramDiscreteValue = new ParameterDiscreteValue();


            paramField.Name = "strCompanyName";
            paramDiscreteValue.Value = cmpanyname;
            paramField.CurrentValues.Add(paramDiscreteValue);
            paramFields.Add(paramField);

            paramField = new ParameterField();
            paramDiscreteValue = new ParameterDiscreteValue();
            paramField.Name = "strCompanyAddress";
            paramDiscreteValue.Value = Address;
            paramField.CurrentValues.Add(paramDiscreteValue);
            paramFields.Add(paramField);

            paramField = new ParameterField();
            paramDiscreteValue = new ParameterDiscreteValue();
            paramField.Name = "strTitle";
            paramDiscreteValue.Value = reportTitle.ToUpper();
            paramField.CurrentValues.Add(paramDiscreteValue);
            paramFields.Add(paramField);

            paramField = new ParameterField();
            paramDiscreteValue = new ParameterDiscreteValue();
            paramField.Name = "strUser";
            paramDiscreteValue.Value = loginuser.ToUpper();
            paramField.CurrentValues.Add(paramDiscreteValue);
            paramFields.Add(paramField);


            paramField = new ParameterField();
            paramDiscreteValue = new ParameterDiscreteValue();
            paramField.Name = "Locacode";
            paramDiscreteValue.Value = loca.ToUpper();
            paramField.CurrentValues.Add(paramDiscreteValue);
            paramFields.Add(paramField);


            paramField = new ParameterField();
            paramDiscreteValue = new ParameterDiscreteValue();
            paramField.Name = "LocaName";
            paramDiscreteValue.Value = locaname.ToUpper();
            paramField.CurrentValues.Add(paramDiscreteValue);
            paramFields.Add(paramField);

            return paramFields;
        }

        //public static object GetDailyCollections(int v)
        //{

        //}

        public static IEnumerable<CollectionSummary> GetDailyCollections(int did, int pumperid, int type)
        {

            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {

                    return db.Query<CollectionSummary>("RPT_DayilyCollectionsummary", new { did = did, punperID = pumperid, type = type }, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static IEnumerable<CollectionSummary> GetSalesTypeWiseDetails(int did, int pumperid, int type)
        {

            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {

                    return db.Query<CollectionSummary>("RPT_SalesTypeWiseDetails", new { did = did, punperID = pumperid, type = type }, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static IEnumerable<ColSummary> GetDailyCollectionsForSummary(int did, int pumperid, int type)
        {

            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {

                    return db.Query<ColSummary>("RPT_DayilyCollectionsummary", new { did = did, punperID = pumperid, type = type }, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static IEnumerable<CustomerBalance> GetCustomerBalance(int customerid)
        {

            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {

                    return db.Query<CustomerBalance>("Rpt_CustomerBalance", new { customerid = customerid }, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
