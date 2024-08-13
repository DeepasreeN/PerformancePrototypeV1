using Microsoft.EntityFrameworkCore;
using PerformancePrototypeV1.API.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformancePrototypeV1.API.DAL.Repositories
{
    public class TransactionRepository : Repository<TransactionDetail>, ITransactionRepository
    {
        public TransactionRepository(InformationDBContext context) : base(context)
        {
        }
    }
}
