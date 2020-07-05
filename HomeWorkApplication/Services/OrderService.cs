using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HomeWorkApplication.DAL;
using HomeWorkApplication.DAL.Entities;
using HomeWorkApplication.Models.OrderModels;
using HomeWorkApplication.Services.Contracts;

namespace HomeWorkApplication.Services
{
    public class OrderService: IOrderService
    {
        private IUnitOfWorkFactory _unitOfWorkFactory { get; set; }

        public OrderService(IUnitOfWorkFactory unitOfWorkFactory)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
        }

        public bool CreateOrder(int UserId, int CafeId, string JsonDishes)
        {
            using (var _uow = _unitOfWorkFactory.Create())
            {
                var Order = new Order { UserId = UserId, CafeId = CafeId, JsonDishes = JsonDishes};
                if (_uow.Orders.GetAll().Count() == 0)
                {
                    _uow.Orders.Create(Order);
                    return true;
                }
                else
                    return false;
            }
        }

        public OrderViewModel GetOrderViewModel(int UserId)
        {
            using (var _uow = _unitOfWorkFactory.Create())
            {
                var Order = _uow.Orders.GetAll().Where(i => i.UserId == UserId);
                if(Order != null)
                    return Mapper.Map<OrderViewModel>(Order);
                else
                    return new OrderViewModel();
                
            }
        }
    }
}
