using Core.DataAccess;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfOrderDal : EfEntityRepositoryBase<Order, SkateboardContext>, IOrderDal
    {
        public List<Order> GetAllWithOrderBy()
        {
            using (SkateboardContext context=new SkateboardContext())
            {
                return context.Set<Order>()
                    .OrderByDescending(p=>p.OrderId).ToList();
            }
        }
    }
}
