using Domain.Entities;
using Domain.IRepositories;
using Infrastructure.Context;
using Infrastructure.Repositories;
using Infrastructure.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            Manual m = new Manual();
            User u = m.vuser();
            System.Console.WriteLine("Terminal");
            System.Console.WriteLine(string.Format("{0} {1} {2}", u.Id,u.Name,u.Age));

            User ucreate = new User
            {
               
                Name = "ManuelVillegas",
                Age=30
            };

            m.vusercreate(ucreate);

            User udetele = new User
            {
                Id = 4,  
                Name = "EmelyLou",   
                Age =26
            };

            //m.vuserdelete(udetele);

            User uupdate = new User
            {
                Id = 14,
                Name = "ManuelVillegasUpdate10",
                Age = 30
            };

            m.vuserupdate(uupdate);

            var ListaU = m.ListUser();
            System.Console.Write(string.Format("{0}", ListaU.Count()));
        }

        public class Manual
        {
            public UnitOfWork unitOfWork = new UnitOfWork();

            public IEnumerable<User> ListUser()
            {
                return unitOfWork.UserRepository.Get();
            }
            public User vuser() {
            User user = unitOfWork.UserRepository.GetByID(2);
                return user;
            }

            public void vusercreate(User user)
            {
                unitOfWork.UserRepository.Insert(user);
                unitOfWork.Save();
            }

            public void vuserdelete(User user)
            {
                unitOfWork.UserRepository.Delete(user);
                unitOfWork.Save();
            }
            

            public  void vuserupdate(User user)
            {
                unitOfWork.UserRepository.Update(user);
                unitOfWork.Save();
            }
        }

    }

    
}
