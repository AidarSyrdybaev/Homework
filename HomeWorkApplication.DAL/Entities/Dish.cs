using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkApplication.DAL.Entities
{
    public class Dish : Entity
    {
        public int Id { get ; set ; }

        public int Name { get; set; }

        public int Description { get; set; }

        public int CafeId { get; set; }

        public Cafe Cafe { get; set; }

    }
}
