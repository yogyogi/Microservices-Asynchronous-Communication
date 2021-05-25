using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public record OrderCreated(Guid Id, string Address, int Quantity, DateTimeOffset CreatedDate);
    public record OrderUpdated(Guid Id, string Address, int Quantity, DateTimeOffset CreatedDate);
    public record OrderDeleted(Guid Id);
}
