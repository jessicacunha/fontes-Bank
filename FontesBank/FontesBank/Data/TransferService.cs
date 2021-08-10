using FontesBank.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FontesBank.Data
{
    public class TransferService : ITransferService
    {
        private readonly IConfiguration _config;
        public TransferService(IConfiguration _config)
        {
            this._config = _config;
        }

        public async Task SaveTransfer(TransferModel transferModel)
        {              
            string sql = "insert into transaction(FromUserId, ToUserId, Amount, Date) values (@UserFromId, @UserToId, @Amount, Now())";
            await DatabaseService.SaveData(sql, transferModel, _config.GetConnectionString("default"));
        }

        public async Task<List<TransferModel>> GetTransferById(int customerId)
        {
            string sql = "SELECT f.Id, f.FromUserId as UserFromId, f.ToUserId as UserToId, f.Amount, f.Date, " +
                "(SELECT Name from fontesbank.users where Id = if(f.FromUserId  = " + customerId + ", f.ToUserId, f.FromUserId)) as UserName FROM fontesbank.transaction f where FromUserId = " + customerId + " or ToUserId = " + customerId;
            return await DatabaseService.LoadData<TransferModel, dynamic>(sql, new { }, _config.GetConnectionString("default"));
        }


    }
}
