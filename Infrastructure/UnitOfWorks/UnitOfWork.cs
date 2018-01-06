using Domain.Entities;
using Domain.IUnitOfWorks;
using Infrastructure.Context;
using Infrastructure.Repositories;
using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.UnitOfWorks
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private DbContextEF context = new DbContextEF();
        private Repository<User> userRepositoryUW;
        private UserRepository userRepository;

        public Repository<User> UserRepositoryUW
        {
            get
            {

                if (this.userRepositoryUW == null)
                {
                    this.userRepositoryUW = new Repository<User>(context);
                }
                return userRepositoryUW;
            }
        }

        public UserRepository UserRepository
        {
            get
            {

                if (this.userRepository == null)
                {
                    this.userRepository = new UserRepository(context);
                }
                return userRepository;
            }
        }
        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }

}
