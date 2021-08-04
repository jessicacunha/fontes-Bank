using Dapper;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DataLibrary
{

    public class DataAccess
    {
        public List<T> LoadData<T, U>(string sql, U parameters, string connectionsString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionsString))
            {
                List<T> rows = connection.Query<T>(sql, parameters).ToList();

                return rows;
            }
        }

        public void SaveData<T>(string sql, T parameters, string connectionsString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionsString))
            {
                connection.Execute(sql, parameters);
            }
        }
    }
    
}
