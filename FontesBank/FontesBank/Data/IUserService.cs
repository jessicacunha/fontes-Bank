using FontesBank.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FontesBank.Data
{
    public interface IUserService
    {
        Task<List<UserModel>> GetUsers();
        Task<UserModel> GetUserById(int customerId);

    }
}