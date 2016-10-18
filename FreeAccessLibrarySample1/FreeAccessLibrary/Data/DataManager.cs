using FreeAccessLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;

namespace FreeAccessLibrary.Data
{
    public class DataManager : IDataManager
    {
        private string _ConnStr;

        public DataManager()
            : this(string.Empty)
        { }

        public DataManager(string connectionString)
        {
            _ConnStr = connectionString;
        }

        public string ConnectionString
        {
            get { return _ConnStr; }
            set { _ConnStr = value; }
        }

        public int ExecuteQuery(string query, List<YasoParameter> parameters)
        {
            try
            {
                int result = -1;

                using (Connection conn = new Connection(_ConnStr))
                {
                    result = conn.Execute(CommandType.Text, query, parameters);
                }

                return result;
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public int ExecuteProcedure(string query, List<YasoParameter> parameters)
        {
            try
            {
                int result = -1;

                using (Connection conn = new Connection(_ConnStr))
                {
                    result = conn.Execute(CommandType.StoredProcedure, query, parameters);
                }

                return result;
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public DataSet GetResultSetOfQuery(string query)
        {
            try
            {
                DataSet ds = null;
                using (Connection conn = new Connection(_ConnStr))
                {
                    ds = conn.GetResultSet(CommandType.Text, query);
                }
                return ds;
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public DataSet GetResultSetOfQuery(string query, List<YasoParameter> parameters)
        {
            try
            {
                DataSet ds = null;
                using (Connection conn = new Connection(_ConnStr))
                {
                    ds = conn.GetResultSet(CommandType.Text, query, parameters);
                }
                return ds;
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public DataSet GetResultSetOfProcedure(string procedure)
        {
            try
            {
                DataSet ds = null;
                using (Connection conn = new Connection(_ConnStr))
                {
                    ds = conn.GetResultSet(CommandType.StoredProcedure, procedure);
                }
                return ds;
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public int Insert(string tableName, List<YasoParameter> columns)
        {
            int result = -1;

            try
            {
                if (string.IsNullOrWhiteSpace(tableName))
                {
                    throw new Exception("Table Name can not be null or empty.");
                }

                if (columns == null)
                {
                    throw new Exception("Parameter List can not be null.");
                }

                if (columns.Count == 0)
                {
                    throw new Exception("Parameter List can not be empty.");
                }

                string sql = "INSERT INTO #TABLE_NAME#(#COLUMNS#) VALUES(#VALS#);";
                sql = sql.Replace("#TABLE_NAME#", tableName);
                string cols = "";
                string vals = "";

                foreach (var item in columns)
                {
                    if (item != null)
                    {
                        if (!(string.IsNullOrWhiteSpace(item.Name) | "Id".Equals(item.Name)))
                        {
                            cols = string.Format("{0}{1}, ", cols, item.Name);
                            vals += "?, ";
                        }
                    }
                }

                cols = cols.TrimEnd().TrimEnd(',');
                vals = vals.TrimEnd().TrimEnd(',');

                sql = sql.Replace("#COLUMNS#", cols);
                sql = sql.Replace("#VALS#", vals);

                result = ExecuteQuery(sql, columns);
            }
            catch (Exception)
            {
                throw;
            }

            return result;
        }

        public int Update(string tableName, List<YasoParameter> columns)
        {
            int result = -1;

            try
            {
                if (string.IsNullOrWhiteSpace(tableName))
                {
                    throw new Exception("Table Name can not be null or empty.");
                }

                if (columns == null)
                {
                    throw new Exception("Parameter List can not be null.");
                }

                if (columns.Count == 0)
                {
                    throw new Exception("Parameter List can not be empty.");
                }

                string sql = "UPDATE #TABLE_NAME# SET #COLUMNS# WHERE Id=?;";
                sql = sql.Replace("#TABLE_NAME#", tableName);
                string cols = "";
                List<YasoParameter> parameters = new List<YasoParameter>();
                object objid = 0;
                foreach (var item in columns)
                {
                    if (item != null)
                    {
                        if ("Id".Equals(item.Name))
                        {
                            objid = item.Value;
                        }
                        if (!(string.IsNullOrWhiteSpace(item.Name) | "Id".Equals(item.Name)))
                        {
                            cols = string.Format("{0}{1}=?, ", cols, item.Name);
                            parameters.Add(new YasoParameter { Name = item.Name, Value = item.Value });
                        }
                    }
                }

                cols = cols.TrimEnd().TrimEnd(',');

                sql = sql.Replace("#COLUMNS#", cols);

                parameters.Add(new YasoParameter { Name = "Id", Value = objid });

                result = ExecuteQuery(sql, parameters);
            }
            catch (Exception)
            {
                throw;
            }

            return result;
        }

        public int Delete(string tableName, int pid)
        {
            int result = -1;
            try
            {
                if (string.IsNullOrWhiteSpace(tableName))
                {
                    throw new Exception("Table Name can not be null or empty.");
                }

                if (pid > 0)
                {
                    List<YasoParameter> h = new List<YasoParameter>();
                    h.Add(new YasoParameter { Name = "Id", Value = pid });

                    string sql = "DELETE FROM #TABLE_NAME# WHERE Id=?";
                    sql = sql.Replace("#TABLE_NAME#", tableName);
                    result = ExecuteQuery(sql, h);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }
    }
}