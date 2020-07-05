using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HomeWorkApplication.DAL;
using HomeWorkApplication.DAL.Entities;
using HomeWorkApplication.Models.Bucket;
using HomeWorkApplication.Models.BucketModels;
using HomeWorkApplication.Services.Contracts;
using Newtonsoft.Json;

namespace HomeWorkApplication.Services
{
    public class BucketService: IBucketService
    {
        private readonly IUnitOfWorkFactory _unitOfWorkFactory;

        public BucketService(IUnitOfWorkFactory unitOfWorkFactory)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
        }

        public void AddDishInBucket(int DishId, int CafeId, int UserId)
        {
            using (var uow = _unitOfWorkFactory.Create())
            {
                var Bucket = uow.Buckets.GetAll().FirstOrDefault(i => i.CafeId == CafeId && i.UserId == UserId);
                if (Bucket != null)
                {
                    var BucketItems = JsonConvert.DeserializeObject<List<BucketItem>>(Bucket.JsonDishes);
                    var BucketItem = BucketItems.FirstOrDefault(i => i.Id == DishId);
                    if (BucketItems.Count >= 1 && BucketItem != null)
                    {
                        BucketItems.Remove(BucketItem);
                        BucketItem.DishCount++;
                        BucketItems.Add(BucketItem);
                    }
                    else
                    {
                        BucketItems.Add(new BucketItem { Id = DishId, DishCount = 1 });
                    }

                    Bucket.JsonDishes = JsonConvert.SerializeObject(BucketItems);
                    uow.Buckets.Update(Bucket);
                }
                else
                {
                    Bucket = new Bucket { UserId = UserId, CafeId = CafeId};
                    List<BucketItem> bucketItems = new List<BucketItem>();
                    bucketItems.Add(new BucketItem{Id = DishId, DishCount = 1});
                    Bucket.JsonDishes = JsonConvert.SerializeObject(bucketItems);
                    uow.Buckets.Create(Bucket);
                }
                
            }
        }

        public void DeleteDishInBucket(int DishId, int CafeId, int UserId)
        {
            using (var uow = _unitOfWorkFactory.Create())
            {
                var Bucket = uow.Buckets.GetAll().FirstOrDefault(i => i.CafeId == CafeId && i.UserId == UserId);
                var BucketItems = JsonConvert.DeserializeObject<List<BucketItem>>(Bucket.JsonDishes);
                var BucketItem = BucketItems.FirstOrDefault(i => i.Id == DishId);
                BucketItems.Remove(BucketItem);
                Bucket.JsonDishes = JsonConvert.SerializeObject(BucketItems);
                uow.Buckets.Update(Bucket);

            }
        }

        public int ReturnBucketId(int DishId, int CafeId, int UserId)
        {
            using (var uow = _unitOfWorkFactory.Create())
            {
                var Bucket = uow.Buckets.GetAll().FirstOrDefault(i => i.CafeId == CafeId && i.UserId == UserId);
                return Bucket.Id;

            }
        }

        public BucketDetailsModel GetUserBucketDetailsModel(int Id)
        {
            using (var uow = _unitOfWorkFactory.Create())
            {
                var Bucket = uow.Buckets.GetById(Id);
                var BucketModel = Mapper.Map<BucketDetailsModel>(Bucket);
                foreach (var BucketItem in BucketModel.BucketItems )
                {
                    BucketItem.Dish = uow.Dishes.GetById(BucketItem.Id);
                    
                }

                BucketModel.Cafe = uow.Cafees.GetById(BucketModel.CafeId);
                return BucketModel;
            }
        }

        public List<BucketViewModel> GetUserBucketViewModels(int Id)
        {
            using (var uow = _unitOfWorkFactory.Create())
            {
                var Buckets = uow.Buckets.GetAllBucketsWithUserWithCafe(Id);
                return Mapper.Map<List<BucketViewModel>>(Buckets);
            }
        }

        
    }
}
