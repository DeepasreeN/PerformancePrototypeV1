using PerformancePrototypeV1.API.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformancePrototypeV1.API.DAL.Repositories
{
    public interface ITransactionRepository : IRepository<TransactionDetail>
    {
       // Task<TransactionDetail> GetByIdAsync(Guid transactionId);
    }
}
