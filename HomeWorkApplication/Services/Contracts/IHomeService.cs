using HomeWorkApplication.DAL.Entities;
using HomeWorkApplication.Models.CafeModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWorkApplication.Services.Contracts
{
    public interface IHomeService
    {
        List<CafeViewModel> GetCafeViewModels();

        CafeDetailsModel GetCafeDetailsModel(int Id);
    }
}
