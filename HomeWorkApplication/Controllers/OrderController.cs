using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeWorkApplication.DAL.Entities;
using HomeWorkApplication.Services.Contracts;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HomeWorkApplication.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;

        private readonly UserManager<User> _userManager;

        public OrderController(IOrderService orderService, UserManager<User> userManager)
        {
            _orderService = orderService;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            var user = _userManager.GetUserAsync(User);
            var OrderModel = _orderService.GetOrderViewModel(user.Id);
            return View(OrderModel);
        }

        public async Task<IActionResult> ToOrder(int UserId, int CafeId, string JsonDishes)
        {
            var Check = _orderService.CreateOrder(UserId, CafeId, JsonDishes);
            if (Check)
            {
                return RedirectToAction("Index", "Order");
            }
            else
            {
                throw new Exception("Вы уже осуществили заказ");
            }
                
        }
    }
}
