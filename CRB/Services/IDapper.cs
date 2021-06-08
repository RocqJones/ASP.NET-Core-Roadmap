// Interface dapper - performs the Crud Operations in our project.
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace Dapper_ORM.Services
{
    public interface IDapper : IDisposable
    {
        DbConnection GetDbConnection();
        T Get<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);
        List<T> GetAll<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);
        int Execute(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);
        T Insert<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);
        T Update<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);
    }
}