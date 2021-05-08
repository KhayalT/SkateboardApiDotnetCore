using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ISkateboardDal
    {
        List<SkateboardDetailsDto> GetSkateboardDetails();
    }
}
