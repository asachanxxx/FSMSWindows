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
    public class SecurityRepository
    {
        private SqlConnection con;
        string strQuery = "";
        public bool boolAccess = false;
        public bool boolCreate = false;
        public bool boolModify = false;
        public bool boolDelete = false;
        public bool boolPrint = false;
        DataTable dtAuthorityBoolValues;
        string strRight;

        public SecurityRepository()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString);

        }

        public IEnumerable<UserRightsViewModel> GetUserRights(int userID) {
            try
            {
                using (IDbConnection db = con)
                {
                    return db.Query<UserRightsViewModel>("SP_GetUserRights",new { userID= userID }, commandType:CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static bool CheckDBConnection()
        {
            var dbok = false;
            try
            {
                using (IDbConnection db2 = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString))
                {
                    var result =  db2.Query<Employee>("select * from Employees");
                    dbok = true;
                }
                return dbok;
            }
            catch (Exception ex)
            {
                return dbok;
            }
        }

        public DataTable CreateDataTable(IEnumerable<UserRightsViewModel> dtUserRights)
        {
            dtAuthorityBoolValues = new DataTable();
            dtAuthorityBoolValues.Columns.Add("UIName", typeof(string));
            dtAuthorityBoolValues.Columns.Add("role name", typeof(string));
            dtAuthorityBoolValues.Columns.Add("Role ID", typeof(string));
            dtAuthorityBoolValues.Columns.Add("menuRights", typeof(string));
            dtAuthorityBoolValues.Columns.Add("dtAccess", typeof(bool));
            dtAuthorityBoolValues.Columns.Add("dtCreate", typeof(bool));
            dtAuthorityBoolValues.Columns.Add("dtModify", typeof(bool));
            dtAuthorityBoolValues.Columns.Add("dtDelete", typeof(bool));
            dtAuthorityBoolValues.Columns.Add("dtPrint", typeof(bool));
            dtAuthorityBoolValues.Columns.Add("Code", typeof(string));

            foreach (UserRightsViewModel item in dtUserRights)
            {
                strRight = item.MenuRights.ToString();
                if (strRight == null)
                    throw new Exception("Invalied User Rights Configurations.");

                for (int j = 0; j < (strRight.Trim()).Length; j++)
                {
                    if (strRight[j] == 'A')
                        boolAccess = true;
                    if (strRight[j] == 'C')
                        boolCreate = true;
                    if (strRight[j] == 'M')
                        boolModify = true;
                    if (strRight[j] == 'D')
                        boolDelete = true;
                    if (strRight[j] == 'P')
                        boolPrint = true;
                }


                dtAuthorityBoolValues.Rows.Add(item.MenuName, item.Role.ToString(), item.Role.ToString(), item.MenuRights.ToString(), boolAccess, boolCreate, boolModify, boolDelete, boolPrint,item.MenuTagCode);
                boolAccess = false;
                boolCreate = false;
                boolModify = false;
                boolDelete = false;
                boolPrint = false;
            }
            return dtAuthorityBoolValues;
        }

    }
}
