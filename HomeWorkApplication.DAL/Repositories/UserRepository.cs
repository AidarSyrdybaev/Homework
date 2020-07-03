using System;
using System.Collections.Generic;
using System.Text;
using HomeWorkApplication.DAL.Entities;
using HomeWorkApplication.DAL.Repositories.Contracts;

namespace HomeWorkApplication.DAL.Repositories
{
    public class UserRepository: Repository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
            entities = applicationDbContext.Users;
        }
    }
}
