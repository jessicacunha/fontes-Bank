using System.Collections.Generic;
using System.Threading.Tasks;

namespace FontesBank.Data
{
    public interface IUserService
    {
        Task<List<T>> LoadData<T, U>(string sql, U parameters, string connectionsString);

        Task SaveData<T>(string sql, T parameters, string connectionsString);
    }
}