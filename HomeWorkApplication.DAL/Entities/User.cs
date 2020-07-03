using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace HomeWorkApplication.DAL.Entities
{
    public class User: IdentityUser<int>, Entity
    {
        public int BucketId { get; set; }

        public Bucket Bucket { get; set; }
    }
}
