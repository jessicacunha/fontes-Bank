using Dapper;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace FontesBank.Data
{
    public static class DatabaseService
    {
        public static async Task<List<T>> LoadData<T, U>(string sql, U parameters, string connectionsString)
        {
            using IDbConnection connection = new MySqlConnection(connectionsString);
            var rows = await connection.QueryAsync<T>(sql, parameters);

            return rows.ToList();
        }

        public static Task SaveData<T>(string sql, T parameters, string connectionsString)
        {
            using IDbConnection connection = new MySqlConnection(connectionsString);
            return connection.ExecuteAsync(sql, parameters);
        }

        public static async Task<T> LoadDataOne<T, U>(string sql, U parameters, string connectionsString)
        {
            using IDbConnection connection = new MySqlConnection(connectionsString);
            var rows = await connection.QueryAsync<T>(sql, parameters);

            return rows.FirstOrDefault();
        }

        public static Task UpdateData<T>(string sql, T parameters, string connectionsString)
        {
            using IDbConnection connection = new MySqlConnection(connectionsString);
            return connection.ExecuteAsync(sql, parameters);
        }
                        
    }
}
