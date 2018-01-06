using Domain.Entities;
using Domain.IRepositories;
using Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class UserRepository : Repository<User>, IRepositoryUser
    {
        public UserRepository(DbContextEF context) : base(context)
        {
        }

        public void MethodSpecificUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
