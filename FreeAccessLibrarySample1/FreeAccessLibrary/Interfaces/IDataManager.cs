using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FreeAccessLibrary.Interfaces
{

    public interface IDataManager
    {
        string ConnectionString { get; set; }

        DataSet GetResultSetOfQuery(string query);

        DataSet GetResultSetOfProcedure(string procedure);
    }
}
