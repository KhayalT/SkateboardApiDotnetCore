using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;
        ISkateboardDal _skateboarDal;
        IColorDal _colorDal;

        public OrderManager(IOrderDal orderDal, ISkateboardDal skateboardDal,IColorDal colorDal)
        {
            _orderDal = orderDal;
            _skateboarDal = skateboardDal;
            _colorDal = colorDal;
        }

        [ValidationAspect(typeof(OrderValidator))]
        public IResult Add(Order order)
        {

            if (CheckIfProductIdExists(order.ProductId).Success == true 
                && CheckIfColorIdExists(order.ColorId).Success==true)
            {
                _orderDal.Add(order);
                return new SuccessResult();
            }
            return new ErrorResult(Messages.CredentialMessage);

        }

        public IDataResult<List<Order>> GetAll()
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll());
        }

        private IResult CheckIfColorIdExists(int colorId)
        {
            var result = _colorDal.GetAll(p => p.Id == colorId).Any();
            if (result)
            {
                return new SuccessResult();
            }
            return new ErrorResult();
        }  
        
        private IResult CheckIfProductIdExists(int productId)
        {
            var result = _skateboarDal.GetAll(p => p.SkateboardId == productId).Any();
            if (result)
            {
                return new SuccessResult();
            }
            return new ErrorResult();
        }
    }
}
