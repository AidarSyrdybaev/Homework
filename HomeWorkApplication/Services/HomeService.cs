using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HomeWorkApplication.DAL;
using HomeWorkApplication.Models.CafeModels;
using HomeWorkApplication.Services.Contracts;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers;

namespace HomeWorkApplication.Services
{
    public class HomeService: IHomeService
    {
        private IUnitOfWorkFactory _unitOfWorkFactory { get; set; }

        public HomeService(IUnitOfWorkFactory unitOfWorkFactory)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
        }

        public List<CafeViewModel> GetCafeViewModels()
        {
            using (var uow = _unitOfWorkFactory.Create())
            {
                var Cafees = uow.Cafees.GetAll().ToList();
                var CafeModels = Mapper.Map<List<CafeViewModel>>(Cafees);
                return CafeModels;
            }
        }

        public CafeDetailsModel GetCafeDetailsModel(int Id)
        {
            using (var uow = _unitOfWorkFactory.Create())
            {
                var Cafe = uow.Cafees.GetCafeAllDish(Id);
                return Mapper.Map<CafeDetailsModel>(Cafe);
            }
        }
    }
}
