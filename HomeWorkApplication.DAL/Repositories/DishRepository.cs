using HomeWorkApplication.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using HomeWorkApplication.DAL.Repositories.Contracts;

namespace HomeWorkApplication.DAL.Repositories
{
    public class DishRepository: Repository<Dish>, IDishRepository
    {
        public DishRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
            entities = applicationDbContext.Dishes;
        }
    }
}
