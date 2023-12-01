using static ProcessCenter.Infrastructure.Dtos;

namespace ProcessCenter.Client
{
    public class OrderClient
    {
        private readonly HttpClient httpClient;
        public OrderClient(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IReadOnlyCollection<OrderDto>> GetOrderAsync()
        {
            var items = await httpClient.GetFromJsonAsync<IReadOnlyCollection<OrderDto>>("/order");
            return items;
        }
    }
}
