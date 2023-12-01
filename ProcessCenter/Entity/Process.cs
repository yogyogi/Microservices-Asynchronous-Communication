using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessCenter.Entity
{
    public class Process : IEntity
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public Guid DroneId { get; set; }
        public string Status { get; set; }
        public DateTimeOffset AcquiredDate { get; set; }
    }
}
