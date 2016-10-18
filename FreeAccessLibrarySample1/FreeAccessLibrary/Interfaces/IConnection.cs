using System;
using System.Data;

namespace FreeAccessLibrary.Interfaces
{
    internal interface IConnection : IDisposable
    {
        IDbConnection CreateConnection();

        IDbConnection CreateConnection(string connectionString);

        void OpenConnection();

        void CloseConnection();

        ConnectionState GetConnectionState();

        void CommitTransaction();

        void RollbackTransaction();

        void CreateTransaction();

        IDbCommand CreateCommand();

        IDbDataParameter CreateParameter(IDbCommand dbCmd);

        IDbDataAdapter CreateAdapter(IDbCommand dbCmd);

        string ConnectionString { get; set; }

        DataSet GetResultSet(CommandType cmdType, string Query);
    }
}