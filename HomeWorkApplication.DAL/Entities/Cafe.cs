﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkApplication.DAL.Entities
{
    public class Cafe: Entity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<Dish> Dishes { get; set; }

        public List<Bucket> Buckets { get; set; }

        public List<Order> Order { get; set; }
    }
}
