using Microsoft.AspNetCore.Mvc;
using PerformancePrototypeV1.API.Common;
using PerformancePrototypeV1.API.DAL.Model;
using PerformancePrototypeV1.API.Service.Transaction;

namespace PerformancePrototypeV1.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionService _transactionService;

        public TransactionController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [HttpGet]
        public async Task<ApiResponse<IEnumerable<TransactionDetail>>> Get()
        {
            var data = await _transactionService.GetAllTransactionData();
            if (data == null)
            {
                return new ApiResponse<IEnumerable<TransactionDetail>>
                {
                    Success = false,
                    Message = "Transaction not found",
                    Data = null
                };
            }

            return new ApiResponse<IEnumerable<TransactionDetail>>
            {
                Success = true,
                Message = "Transactions retrieved successfully",
                Data = data
            };

        }

    }
}
