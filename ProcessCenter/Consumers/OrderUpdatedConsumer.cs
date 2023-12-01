using Infrastructure;
using MassTransit;
using ProcessCenter.Entity;

namespace ProcessCenter.Consumers
{
    public class OrderUpdatedConsumer : IConsumer<OrderUpdated>
    {
        private readonly IRepository<Order> repository;
        public OrderUpdatedConsumer(IRepository<Order> repository)
        {
            this.repository = repository;
        }

        public async Task Consume(ConsumeContext<OrderUpdated> context)
        {
            var message = context.Message;
            var item = await repository.GetAsync(message.Id);
            if (item == null)
            {
                item = new Order
                {
                    Id = message.Id,
                    Address = message.Address,
                    Quantity = message.Quantity
                };
                await repository.CreateAsync(item);
            }
            else
            {
                item.Address = message.Address;
                item.Quantity = message.Quantity;

                await repository.UpdateAsync(item);
            }
        }
    }
}
