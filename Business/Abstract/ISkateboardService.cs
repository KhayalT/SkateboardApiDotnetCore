using Core.Utilities.Results;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISkateboardService
    {
        IDataResult<List<SkateboardDetailsDto>> GetAllSkateboardDetails();
    }
}
