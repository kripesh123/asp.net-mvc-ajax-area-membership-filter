using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Kripesh.WebStore.Application.Models;
using Kripesh.WebStore.Application.Repository;


namespace Kripesh.WebStore.Application.Repository
{
    public interface IUserRepository : IGenericRepository<User>
    {
        User Login(string username, string password);
    }
    public class UserRepository : IUserRepository
    {
        public int Delete(User e)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            return new List<User>()
            {
                new User()
                {
                    Id=1,UserName="admin",Password="admin",Email="admin@gmail.com",Status=true
                },
                new User()
                {
                    Id=2,UserName="user",Password="user",Email="user@gmail.com",Status=true
                },
                new User()
                {
                    Id=3,UserName="invalid",Password="invalid",Email="invalid@gmail.com",Status=false
                }
            };
        }

        public User GetById(int id)
        {
            return GetAll().Where(m => m.Id == id).Single();
        }

        public int Insert(User e)
        {
            throw new NotImplementedException();
        }

        public User Login(string username, string password)
        {
            var user = (from u in GetAll() where u.UserName == username && u.Password == password select u).ToList();
            if(user.Count > 0)
            {
                return user.Single();
            }
            return null;
        }

        public List<User> Search(Expression<Func<User>> e)
        {
            throw new NotImplementedException();
        }

        public int Update(User e)
        {
            throw new NotImplementedException();
        }
    }
}