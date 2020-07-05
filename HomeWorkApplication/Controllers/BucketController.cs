using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeWorkApplication.DAL.Entities;
using HomeWorkApplication.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Operations;

namespace HomeWorkApplication.Controllers
{
    public class BucketController : Controller
    {
        private readonly IBucketService _BucketService;

        private readonly UserManager<User> _userManager;

        public BucketController(UserManager<User> userManager, IBucketService BucketService)
        {
            _userManager = userManager;
            _BucketService = BucketService;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            var BucketModels = _BucketService.GetUserBucketViewModels(user.Id);
            return View(BucketModels);
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Add(int DishId, int CafeId)
        {
            var user = await _userManager.GetUserAsync(User);
            _BucketService.AddDishInBucket(DishId, CafeId, user.Id);
            return RedirectToAction("Details", "Home", new {Id = CafeId});
        }

        public async Task<IActionResult> Details(int Id)
        {
            var BucketModel = _BucketService.GetUserBucketDetailsModel(Id);
            return View(BucketModel);
        }
        [Authorize]
        public async Task<IActionResult> Delete(int DishId, int CafeId)
        {
            var user = await _userManager.GetUserAsync(User);
            _BucketService.DeleteDishInBucket(DishId, CafeId, user.Id);
            return RedirectToAction("Details", "Bucket", new {Id = _BucketService.ReturnBucketId(DishId, CafeId, user.Id)});
        }


    }
}
