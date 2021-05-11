using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
  public   class EfSkateboardDal : EfEntityRepositoryBase<Skateboard, SkateboardContext>, ISkateboardDal
    {
        public List<SkateboardDetailsDto> GetSkateboardDetails()
        {
            using (SkateboardContext context = new SkateboardContext())
            {
                var result = from s in context.Skateboards.Cast<Skateboard>()
                             join t in context.SkateboardTypes
                             on s.TypeId equals t.Id
                             select new SkateboardDetailsDto
                             {
                                 SkateboardId=s.SkateboardId,
                                 SkateboardName=s.Name,
                                 SkateboardType=t.Name,
                                 Price=s.Price,
                                 PrintPrice=s.PrintPrice,
                             };
                return result.ToList();
            }
        }

    }
}
