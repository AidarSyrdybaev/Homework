using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HomeWorkApplication.DAL.Entities;
using HomeWorkApplication.DAL.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace HomeWorkApplication.DAL.Repositories
{
    public class CafeRepository:Repository<Cafe>, ICafeRepository
    {
        public CafeRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
            entities = applicationDbContext.Cafees;
        }

        public Cafe GetCafeAllDish(int Id)
        {
            return entities.Where(c => c.Id == Id).Include(c => c.Dishes).First();
        }
    }
}
