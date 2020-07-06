using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkApplication.DAL.Entities
{
    public class DishPicture: Entity
    {
        public int Id { get; set; }

        public int DishId { get; set; }

        public Dish Dish { get; set; }

        public byte[] Image { get; set; }
    }
}
