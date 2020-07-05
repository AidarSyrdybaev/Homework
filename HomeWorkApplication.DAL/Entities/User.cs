using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace HomeWorkApplication.DAL.Entities
{
    public class User: IdentityUser<int>, Entity
    {
        public List<Bucket> Buckets { get; set; }

        public Order Order { get; set; }
    }
}
