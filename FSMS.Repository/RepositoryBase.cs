using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib.Extensions;
using System.Configuration;

namespace FSMS.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {

        //private SqlConnection con;
        private string _connectionName;
        private string _tablename;

        public RepositoryBase(string Tablename)
        {
            try
            {
                _tablename = Tablename;
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
            }
            catch (Exception ex) {
                throw ex;
            }

        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public T Get(int id)
        {
            if (string.IsNullOrEmpty(_tablename))
            {
                throw new Exception("Table name cannot be a empty value");
            }

            try
            {
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    return db.QuerySingle<T>("select * from " + _tablename + " where id = " + id.ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetAll()
        {
            if (string.IsNullOrEmpty(_tablename))
            {
                throw new Exception("Table name cannot be a empty value");
            }

            try
            {
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    return db.Query<T>("select * from " + _tablename);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<T> GetAll(string field, string value,bool isnumaric)
        {
            if (string.IsNullOrEmpty(_tablename))
            {
                throw new Exception("Table name cannot be a empty value");
            }

            try
            {
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    string str = "";
                    if (isnumaric)
                    {
                        str = "select * from " + _tablename + " where " + field.Trim() + " = " + value;
                    }
                    else {
                        str = "select * from " + _tablename + " where " + field.Trim() + " = '" + value + "'";
                    }

                    return db.Query<T>(str);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Save(T entity)
        {

            try
            {
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    long val = db.Insert(entity);
                    return int.Parse(val.ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Update(T entity)
        {

            try
            {
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    bool val = db.Update(entity);
                    return val;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
