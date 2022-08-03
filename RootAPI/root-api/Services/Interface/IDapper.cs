using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace name_api.Services.Interface
{
    public interface IDapper //: IDisposable
    {
        DbConnection GetDbconnection();
        T Get<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);
        List<T> GetList<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);
        bool ExecuteNonQuery(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);
        T Update<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);
        List<T> ExecuteStoredProcedure<T>(string sp, DynamicParameters parms);
        DataTable ExecuteCommand(string ConnString, string commandName, CommandType cmdType, SqlParameter[] parameters);
    }
}
