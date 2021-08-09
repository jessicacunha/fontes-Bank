using FontesBank.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FontesBank.Data
{
    public interface ITransferService
    {
        Task SaveTransfer(TransferModel transferModel);
        Task<List<TransferModel>> GetTransferById(int customerId);
    }
}
