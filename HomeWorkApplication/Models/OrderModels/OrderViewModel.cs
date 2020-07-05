using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeWorkApplication.Models.BucketModels;

namespace HomeWorkApplication.Models.OrderModels
{
    public class OrderViewModel
    {
        public int Id { get; set; }

        public List<BucketItem> BucketItems { get; set; }
    }
}
