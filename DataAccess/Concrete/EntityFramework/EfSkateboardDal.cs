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
    public class EfSkateboardDal : EfEntityRepositoryBase<Skateboard, SkateboardContext>, ISkateboardDal
    {
        public List<SkateboardDetailsDto> GetSkateboardDetails()
        {
            using (SkateboardContext context = new SkateboardContext())
            {
                var result = context.Skateboards.Select(skateboard => new SkateboardDetailsDto()
                {
                    Price = skateboard.Price,
                    SkateboardId = skateboard.SkateboardId,
                    PrintPrice = skateboard.PrintPrice,
                    SkateboardName = skateboard.Name,
                    Colors = skateboard.SkateboardColors.Select(n => n.Color.Name).ToList(),
                    SkateboardType = context.SkateboardTypes.Where(s => s.Id == skateboard.TypeId).Select(n => n.Name).FirstOrDefault()
                });

                return result.ToList();
            }
        }

    }
}
