using Ordering.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Application.Contracts
{
    public interface IOrderRepository
    {
        Task<IEnumerable<Order>> GetOrdersByUsername(string username);

    }
}
