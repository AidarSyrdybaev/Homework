using System;
using System.Collections.Generic;
using System.Text;
using HomeWorkApplication.DAL.Entities;
using HomeWorkApplication.DAL.Repositories.Contracts;

namespace HomeWorkApplication.DAL.Repositories
{
    public class CafeRepository:Repository<Cafe>, ICafeRepository
    {
        public CafeRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
            entities = applicationDbContext.Cafees;
        }
    }
}
