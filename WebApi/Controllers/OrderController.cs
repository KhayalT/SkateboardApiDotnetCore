using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Concrete;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [ApiController]
    public class OrderController : ControllerBase
    {
        IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        [Route("api/orders")]
        [HttpGet]
        public IActionResult Get()
        {
            var result = _orderService.GetAllWithOrderBy();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
        [Route("api/orders")]
        [HttpPost]
        public IActionResult Post(Order order)
        {
            var result = _orderService.Add(order);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result);
        }
        [Route("api/orders/{id}")]
        public IResult Put(int id, [FromBody] Order order)
        {
        
            using (SkateboardContext context = new SkateboardContext())
            {
                int res=0;
                var entity = context.Orders.FirstOrDefault(e => e.OrderId == id);
                if (order.PreparationDate != null && order.DeliveryDate != null)
                {
                    res = DateTime.Compare((DateTime)order.PreparationDate, (DateTime)order.DeliveryDate);

                }
                if (order.PreparationDate == null || entity.PreparationDate==null && order.DeliveryDate != null)
                {
                    res = DateTime.Compare((DateTime)entity.PreparationDate, (DateTime)order.DeliveryDate);
                }
                else if (order.PreparationDate != null && order.DeliveryDate == null)
                {
                    res = DateTime.Compare((DateTime)order.PreparationDate, (DateTime)entity.DeliveryDate);

                }
                if (res < 0)
                {
                    entity.PreparationDate = order.PreparationDate;
                    entity.DeliveryDate = order.DeliveryDate;
                    context.SaveChanges();
                    return new SuccessResult("Order is Updated");
                }
            }
            return new ErrorResult("Order isn't Updated");
        }
    }
}
