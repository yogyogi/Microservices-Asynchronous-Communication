using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessCenter.Infrastructure
{
    public class Dtos
    {
        public record GrantOrderDto(Guid DroneId, Guid OrderId, String Status);

        public record ProcessDto(Guid OrderId, string Address, int Quantity, string Status, Guid ProcessId, Guid DroneId, DateTimeOffset AcquiredDate);

        public record OrderDto(Guid Id, string Address, int Quantity);
    }
}
