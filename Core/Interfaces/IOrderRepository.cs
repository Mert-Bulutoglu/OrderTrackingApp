using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IOrderRepository
    {
        Task<Order> GerOrderByIdAsnyc(int id);
        Task<IReadOnlyList<Order>> GetOrdersAsync();
        Task<bool> SaveChangesAsync();
        void Add(Order order);
    }
}