using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkApplication.DAL.Entities
{
    public class Order: Entity
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public int CafeId { get; set; }

        public Cafe Cafe { get; set; }

        public string JsonDishes { get; set; }

    }
}
