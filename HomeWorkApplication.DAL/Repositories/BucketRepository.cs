using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HomeWorkApplication.DAL.Entities;
using HomeWorkApplication.DAL.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace HomeWorkApplication.DAL.Repositories
{
    public class BucketRepository: Repository<Bucket>, IBucketRepository
    {
        public BucketRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
            entities = applicationDbContext.Buckets;
        }

        public List<Bucket> GetAllBucketsWithUserWithCafe(int Id)
        {
            return entities.Where(i => i.UserId == Id).Include(i => i.Cafe).ToList();
        }
    }
}
