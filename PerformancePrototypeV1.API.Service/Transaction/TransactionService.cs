using PerformancePrototypeV1.API.DAL.Model;
using PerformancePrototypeV1.API.DAL.Repositories;
using System.Linq;


namespace PerformancePrototypeV1.API.Service.Transaction
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _transactionRepository;
        public TransactionService(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }
        public async Task<IEnumerable<TransactionDetail>> GetAllTransactionData()
        {
            var transaction = await _transactionRepository.GetAllAsync();
            //var transactionData = transaction.Take(10);
            return transaction;
        }
    }
}
