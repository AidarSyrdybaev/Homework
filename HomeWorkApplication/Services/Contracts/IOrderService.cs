using HomeWorkApplication.Models.OrderModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWorkApplication.Services.Contracts
{
    public interface IOrderService
    {
        bool CreateOrder(int UserId, int CafeId, string JsonDishes);

        OrderViewModel GetOrderViewModel(int UserId);
    }
}
