using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeWorkApplication.Models.Bucket;
using HomeWorkApplication.Models.BucketModels;

namespace HomeWorkApplication.Services.Contracts
{
    public interface IBucketService
    {
        List<BucketViewModel> GetUserBucketViewModels(int Id);

        void AddDishInBucket(int DishId, int CafeId, int UserId);

        void DeleteDishInBucket(int DishId, int CafeId, int UserId);

        BucketDetailsModel GetUserBucketDetailsModel(int Id);

        int ReturnBucketId(int DishId, int CafeId, int UserId);
    }
}
