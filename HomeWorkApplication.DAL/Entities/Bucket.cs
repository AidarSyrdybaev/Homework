using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkApplication.DAL.Entities
{
    public class Bucket: Entity
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public string JsonDishes { get; set; }
    }
}
