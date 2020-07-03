using System;
using System.Collections.Generic;
using System.Text;
using HomeWorkApplication.DAL.Entities;
using HomeWorkApplication.DAL.Repositories.Contracts;

namespace HomeWorkApplication.DAL.Repositories
{
    public class BucketRepository: Repository<Bucket>, IBucketRepository
    {
        public BucketRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
            entities = applicationDbContext.Buckets;
        }
    }
}
