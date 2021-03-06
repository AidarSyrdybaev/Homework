﻿using System;
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
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            var OrderModel = _orderService.GetOrderViewModel(user.Id);
            return View(OrderModel);
        }

        public async Task<IActionResult> ToOrder(int CafeId, string JsonDishes)
        {
            var user = await _userManager.GetUserAsync(User);
            var Check = _orderService.CreateOrder(user.Id, CafeId, JsonDishes);
            if (Check)
            {
                return RedirectToAction("Index", "Order");
            }
            else
            {
                ViewBag.BadRequestMessage = "Вы уже осуществили заказ";
                return View("BadRequest");
            }
                
        }
    }
}
