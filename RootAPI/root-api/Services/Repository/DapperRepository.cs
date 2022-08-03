using Dapper;
using name_api.Services.Interface;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace name_api.Services.Repository
{
    public class DapperRepository : IDapper
    {
        private readonly IConfiguration _config;
        private string Connectionstring = "DefaultConnection";
        public DapperRepository(IConfiguration config)
        {
            _config = config;
        }
        public DbConnection GetDbconnection()
        {
            return new SqlConnection(_config.GetConnectionString(Connectionstring));
        }
        public T Get<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
        {
            using IDbConnection db = new SqlConnection(_config.GetConnectionString(Connectionstring));
            return db.Query<T>(sp, parms, commandType: commandType).FirstOrDefault();
        }
        public List<T> GetList<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
        {
            using IDbConnection db = new SqlConnection(_config.GetConnectionString(Connectionstring));
            return db.Query<T>(sp, parms, commandType: commandType).ToList();
        }
        public bool ExecuteNonQuery(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
        {
            bool result = false;
            using IDbConnection db = new SqlConnection(_config.GetConnectionString(Connectionstring));
            try
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();

                using var tran = db.BeginTransaction();
                try
                {
                    int NunberInsert = db.Execute(sp, parms, tran, null, commandType);
                    if(NunberInsert > 0)
                    {
                        result = true;
                        tran.Commit();
                    }
                    else
                    {
                        tran.Rollback();
                    }    
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw ex;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (db.State == ConnectionState.Open)
                    db.Close();
            }

            return result;
        }
        public T Update<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
        {
            T result;
            using IDbConnection db = new SqlConnection(_config.GetConnectionString(Connectionstring));
            try
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();

                using var tran = db.BeginTransaction();
                try
                {
                    result = db.Query<T>(sp, parms, commandType: commandType, transaction: tran).FirstOrDefault();
                    tran.Commit();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw ex;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (db.State == ConnectionState.Open)
                    db.Close();
            }

            return result;
        }
        public List<T> ExecuteStoredProcedure<T>(string sp, DynamicParameters parms)
        {
            List<T> result;
            using IDbConnection db = new SqlConnection(_config.GetConnectionString(Connectionstring));
            try
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();

                using var tran = db.BeginTransaction();
                try
                {
                    result = db.Query<T>(sp, parms, commandType: CommandType.StoredProcedure, transaction: tran).ToList();
                    tran.Commit();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw ex;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (db.State == ConnectionState.Open)
                    db.Close();
            }

            return result;
        }

        public DataTable ExecuteCommand(string ConnString, string commandName, CommandType cmdType, SqlParameter[] parameters)
        {
            if (parameters == null)
            {
                return ExecuteSelectCommand(ConnString, commandName, cmdType);
            }
            DataTable table = null;
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandTimeout = 3000;
                    cmd.CommandText = commandName;
                    cmd.CommandType = cmdType;
                    cmd.Parameters.AddRange(parameters);
                    try
                    {
                        if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            table = new DataTable();
                            adapter.Fill(table);
                        }
                        if (conn.State == System.Data.ConnectionState.Open) conn.Close();
                    }
                    catch
                    {
                        throw;
                    }
                }
            }
            return table;
        }
        private DataTable ExecuteSelectCommand(string ConnString, string CommandName, CommandType cmdType)
        {
            DataTable table = null;
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = CommandName;
                    cmd.CommandType = cmdType;

                    try
                    {
                        if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            table = new DataTable();
                            adapter.Fill(table);
                        }
                        if (conn.State == System.Data.ConnectionState.Open) conn.Close();
                    }
                    catch
                    {
                        throw;
                    }
                }
            }
            return table;
        }
    }
}
