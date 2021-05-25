using Microsoft.AspNetCore.Mvc;
using ProcessCenter.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ProcessCenter.Infrastructure.Dtos;
using ProcessCenter.Infrastructure;

namespace ProcessCenter.Controllers
{
    [ApiController]
    [Route("process")]
    public class ProcessController : ControllerBase
    {
        private readonly IRepository<Process> repository;
        private readonly IRepository<Order> orderRepository;
        public ProcessController(IRepository<Process> repository, IRepository<Order> orderRepository)
        {
            this.repository = repository;
            this.orderRepository = orderRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProcessDto>>> GetAsync(Guid droneId)
        {
            if (droneId == Guid.Empty)
            {
                return BadRequest();
            }
            var processEntities = await repository.GetAllAsync(a => a.DroneId == droneId);
            var itemIds = processEntities.Select(a => a.OrderId);
            var orderEntities = await orderRepository.GetAllAsync(a => itemIds.Contains(a.Id));

            var processDtos = processEntities.Select(a =>
            {
                var orderItem = orderEntities.Single(b => b.Id == a.OrderId);
                return a.AsDto(orderItem.Address, orderItem.Quantity);
            });

            return Ok(processDtos);
        }

        [HttpPost]
        public async Task<ActionResult> PostAsync(GrantOrderDto grantOrderDto)
        {
            var process = await repository.GetAsync(a => a.DroneId == grantOrderDto.DroneId && a.OrderId == grantOrderDto.OrderId);
            if (process == null)
            {
                process = new Process
                {
                    DroneId = grantOrderDto.DroneId,
                    OrderId = grantOrderDto.OrderId,
                    Status = grantOrderDto.Status,
                    AcquiredDate = DateTimeOffset.UtcNow
                };

                await repository.CreateAsync(process);
            }
            else
            {
                process.Status = grantOrderDto.Status;
                await repository.UpdateAsync(process);
            }
            return Ok();
        }
    }
}
