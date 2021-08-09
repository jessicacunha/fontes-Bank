using FontesBank.Models;
using FontesBank.Pages;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace FontesBank.Data
{
    public class UserService : IUserService
    {
        private readonly IConfiguration _config;
        private object _configuration;

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

        public async Task UpdateAmount(TransferModel transferModel)
        {
            string increase = "UPDATE users SET CurrentBalance = CurrentBalance-@Amount where Id = @UserFromId";
            await DatabaseService.UpdateData(increase, transferModel, _config.GetConnectionString("default"));
           
            string decrease = "UPDATE users SET CurrentBalance = CurrentBalance+@Amount where Id = @UserToId";
            await DatabaseService.UpdateData(decrease, transferModel, _config.GetConnectionString("default"));



        }





    }
}



