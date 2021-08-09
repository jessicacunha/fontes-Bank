using Dapper;
using FontesBank.Models;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;


namespace FontesBank.Data
{
    public class UserService : IUserService
    {
        private readonly IConfiguration _config;
        public UserService(IConfiguration _config)
        {
            this._config = _config;
        }

        public async Task<List<UserModel>> GetUsers()
        {
            string sql = "select * from fontesbank.users";
            return await DatabaseService.LoadData<UserModel, dynamic>(sql, new { }, _config.GetConnectionString("default"));
        }

        public async Task<UserModel> GetUserById(int customerId)
        {
            string sql = "select * from fontesbank.users where Id = " + customerId;
            return await DatabaseService.LoadDataOne<UserModel, dynamic>(sql, new { }, _config.GetConnectionString("default"));
        }


    };

}



