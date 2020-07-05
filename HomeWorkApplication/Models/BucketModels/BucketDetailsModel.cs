using HomeWorkApplication.DAL.Entities;
using HomeWorkApplication.Models.BucketModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWorkApplication.Models.BucketModels
{
    public class BucketDetailsModel
    {
        public int Id { get; set; }

        public int CafeId { get; set; }

        public Cafe Cafe { get; set; }

        public List<BucketItem> BucketItems { get; set; }

        public string JsonDishes { get; set; }
    }
}
