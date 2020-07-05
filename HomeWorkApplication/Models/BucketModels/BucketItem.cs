using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using HomeWorkApplication.DAL.Entities;

namespace HomeWorkApplication.Models.BucketModels
{
    public class BucketItem
    {
        public int Id { get; set; }

        [JsonIgnore]

        public Dish Dish { get; set; }

        public int DishCount { get; set; }
    }
}
