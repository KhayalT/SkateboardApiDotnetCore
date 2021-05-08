using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class SkateboardManager : ISkateboardService
    {
        ISkateboardDal _skateboardDal;

        public SkateboardManager(ISkateboardDal skateboardDal)
        {
            _skateboardDal = skateboardDal;
        }

        public IDataResult<List<SkateboardDetailsDto>> GetAllSkateboardDetails()
        {
            return new SuccessDataResult<List<SkateboardDetailsDto>>(_skateboardDal.GetSkateboardDetails());
        }
    }
}
