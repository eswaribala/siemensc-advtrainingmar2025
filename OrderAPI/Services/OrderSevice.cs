using Confluent.Kafka;
using OrderAPI.Models;
using System.Diagnostics;
using System.Net;
using System.Text.Json;

namespace OrderAPI.Services
{
    public class OrderSevice : IOrderService
    {
        public async Task<string> PublishOrder(Order order, IConfiguration configuration)
        {
            string TopicName = configuration["TopicName"];
            ProducerConfig producerConfig = new ProducerConfig
            {
                BootstrapServers = configuration["BootStrapServer"],
                ClientId = Dns.GetHostName()
            };

            try
            {
                //publish the message
                using (var producer = new ProducerBuilder
               <Null, string>(producerConfig).Build())
                {
                    var result = await producer.ProduceAsync
                   (TopicName, new Message<Null, string>
                   {
                       Value = JsonSerializer.Serialize(order)
                   });
                    Debug.WriteLine($"Delivery Timestamp:{result.Timestamp.UtcDateTime}");
                    return await Task.FromResult($"Delivery Timestamp:{result.Timestamp.UtcDateTime}");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error Occurred: {ex.Message}");
                return await Task.FromResult($"Error Occurred: {ex.Message}");


            }
        }
    }
}
