using OrderAPI.Models;

namespace OrderAPI.Services
{
    public class OrderSevice : IOrderService
    {
        public Task<string> PublishOrder(Order order, IConfiguration configuration)
        {
            throw new NotImplementedException();
        }
    }
}
