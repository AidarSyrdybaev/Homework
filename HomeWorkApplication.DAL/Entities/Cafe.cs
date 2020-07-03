using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkApplication.DAL.Entities
{
    public class Cafe: Entity
    {
        public int Id { get; set; }

        public int Name { get; set; }

        public int Description { get; set; }

        public List<Dish> Dishes { get; set; }
    }
}
