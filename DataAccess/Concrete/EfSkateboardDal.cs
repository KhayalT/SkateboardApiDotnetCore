using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    class EfSkateboardDal:EfEntityRepositoryBase<Skateboard,SkateboardContext>,ISkateboardDto
    {
    }
}
