using Microsoft.Data.SqlClient;

namespace ApiDBConnection.Data
{
    public class DataBaseHelper
    {
        private string _connectionString;
        public DataBaseHelper(string connectionString)
        {
            _connectionString = connectionString;
        }
        public SqlConnection GetConnection()
        {
            {
                return new SqlConnection(_connectionString);
            }
        }
    }
}
