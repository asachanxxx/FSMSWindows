using Dapper;
using FSMS.Crypto;
using FSMS.Domain;
using Org.BouncyCastle.Crypto.Engines;
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
    public enum LogType
    {
        Error = 1,
        Message = 2,
        Log = 3,
    }


    public class LogRepository
    {

        private static string _connectionName;


        public static bool Log(string message, LogType type, int userid)
        {
            bool okok = false;
            try
            {
                switch (type)
                {
                    case LogType.Error:
                        if (InsertToLog(message, "ERROR", userid) > 0)
                        {
                            okok = true;
                        }
                        else
                        {
                            okok = false;
                        }
                        break;
                    case LogType.Message:
                        if (InsertToLog(message, "Message", userid) > 0)
                        {
                            okok = true;
                        }
                        else
                        {
                            okok = false;
                        }

                        break;
                    case LogType.Log:
                        if (InsertToLog(message, "Log", userid) > 0)
                        {
                            okok = true;
                        }
                        else
                        {
                            okok = false;
                        }

                        break;
                }
                return okok;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        public static int InsertToLog(string message, string type, int userid)
        {
            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    string messagex = new BCEngine(new AesEngine(), null).AESEncryption(message, true);

                    return db.Execute("SP_InsertLog",
                        new
                        {
                            place = "Any",
                            type = type,
                            mssage = messagex,
                            userid = userid
                        },
                        commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static IEnumerable<SystemLog> GetSystenLog(LogType type, int userid)
        {
            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    IEnumerable<SystemLog> logs = null;

                    switch (type) {
                        case LogType.Log:
                            logs =  db.Query<SystemLog>("select * from systemlogs where [type] = @typez and [user] = @userid order by date",
                                   new { typez = "Log" , userid = userid } );
                            break;
                        case LogType.Error:
                            logs = db.Query<SystemLog>("select * from systemlogs where [type] = @typez and [user] = @userid order by date",
                                   new { typez = "ERROR", userid = userid });
                            break;
                        case LogType.Message:
                            logs = db.Query<SystemLog>("select * from systemlogs where [type] = @typez and [user] = @userid order by date",
                                   new { typez = "Message", userid = userid });
                            break;
                    }
                    return logs;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
