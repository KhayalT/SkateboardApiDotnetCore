using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IOrderService
    {
        IResult Add(Order order);
        IResult Update(Order order);
        IDataResult<List<Order>> GetAll();
        IDataResult<Order> GetOne(int orderId);
        IDataResult<List<Order>> GetAllWithOrderBy();
    }
}
