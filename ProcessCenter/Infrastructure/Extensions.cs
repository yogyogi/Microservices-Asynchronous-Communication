using ProcessCenter.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ProcessCenter.Infrastructure.Dtos;

namespace ProcessCenter.Infrastructure
{
    public static class Extensions
    {
        public static ProcessDto AsDto(this Process process, string Address, int Quantity)
        {
            return new ProcessDto(process.OrderId, Address, Quantity, process.Status, process.Id, process.DroneId, process.AcquiredDate);
        }
    }
}
