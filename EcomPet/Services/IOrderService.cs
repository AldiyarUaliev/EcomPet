using EcomPet.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EcomPet.Services
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderResponseModel>> GetOrdersByUserName(string userName);
    }
}
