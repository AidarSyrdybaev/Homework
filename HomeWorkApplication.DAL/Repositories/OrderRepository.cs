
using System;
using System.Collections.Generic;
using System.Text;
using HomeWorkApplication.DAL.Entities;
using HomeWorkApplication.DAL.Repositories.Contracts;

namespace HomeWorkApplication.DAL.Repositories
{
    public class OrderRepository: Repository<Order>, IOrderRepository
    {
        public OrderRepository(ApplicationDbContext ApplicationDbContext) : base(ApplicationDbContext)
        {
            entities = ApplicationDbContext.Orders;
        }
    }
}
