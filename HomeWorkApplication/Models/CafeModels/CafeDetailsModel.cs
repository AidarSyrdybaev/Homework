using HomeWorkApplication.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWorkApplication.Models.CafeModels
{
    public class CafeDetailsModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<Dish> Dishes { get; set; }
    }
}
