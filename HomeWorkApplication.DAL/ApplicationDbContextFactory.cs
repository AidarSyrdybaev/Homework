using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace HomeWorkApplication.DAL
{
    public interface IApplicationDbContextFactory
    {
        ApplicationDbContext Create();
    }

    public class ApplicationDbContextFactory: IApplicationDbContextFactory
    {
        private readonly DbContextOptions _Options;

        public ApplicationDbContextFactory(DbContextOptions dbContextOptions)
        {
            _Options = dbContextOptions;
        }

        public ApplicationDbContext Create()
        {
            return new ApplicationDbContext(_Options);
        }
    }
}
