using System;
using System.Collections.Generic;
using System.Text;
using HomeWorkApplication.DAL.Repositories;
using HomeWorkApplication.DAL.Repositories.Contracts;

namespace HomeWorkApplication.DAL
{
    public class UnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private bool _disposed;

        public IBucketRepository Buckets { get; }

        public ICafeRepository Cafees { get; }

        public IUserRepository Users { get; }

        public IDishRepository Dishes { get; }

        public UnitOfWork(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
            Buckets = new BucketRepository(applicationDbContext);
            Cafees = new CafeRepository(applicationDbContext);
            Users = new UserRepository(applicationDbContext);
            Dishes = new DishRepository(applicationDbContext);
        }

        #region Disposable
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
                _context.Dispose();

            _disposed = true;
        }

        ~UnitOfWork()
        {
            Dispose(false);
        }
        #endregion

    }
}
