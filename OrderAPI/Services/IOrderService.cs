using OrderAPI.Models;

namespace OrderAPI.Services
{
    public interface IOrderService
    {
        Task<string> PublishOrder(Order order, IConfiguration configuration);
    }
}
