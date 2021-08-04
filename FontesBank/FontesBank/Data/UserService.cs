﻿using Dapper;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;


namespace FontesBank.Data
{
    public class UserService : IUserService
    {
        public async Task<List<T>> LoadData<T, U>(string sql, U parameters, string connectionsString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionsString))
            {
                var rows = await connection.QueryAsync<T>(sql, parameters);

                return rows.ToList();
            }
        }

        public Task SaveData<T>(string sql, T parameters, string connectionsString)
        {
            using IDbConnection connection = new MySqlConnection(connectionsString);
            return connection.ExecuteAsync(sql, parameters);
        }

        //private readonly List<Customer> customers = new List<Customer>()
        //{
        //    new Customer{ Name = "Jessica Fontes", Email = "jessiksu@gmail.com" },
        //    new Customer{ Name = "Jessica Fontes", Email = "jessiksu@gmail.com" }
        //};

        //public Task<List<Customer>> GetForecastAsync()
        //{
        //    return Task.FromResult(customers);
        //}
    };

}



