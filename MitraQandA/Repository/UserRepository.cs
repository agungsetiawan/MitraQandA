using MitraQandA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MitraQandA.Repository
{
    public class UserRepository
    {
        protected QnAContext context = new QnAContext();

        public User GetUserByUsername(string username)
        {
            User userFound = context.Users.Where(u=>u.Username==username).SingleOrDefault();
            return userFound;
        }

        public User GetUserByEmail(string email)
        {
            User userFound = context.Users.SingleOrDefault(u => u.Email == email);
            return userFound;
        }

        public List<User> GetUserByName(string name, int offset, int size)
        {
            List<User> usersFound =(List<User>) context.Users.Where(u => u.FirstName.Contains(name) || u.LastName.Contains(name))
                                                 .Skip(offset).Take(size);
            return usersFound;
        }

        public User GetUserByEmailAndPassword(string email, string password)
        {
            User userFound = context.Users.SingleOrDefault(u => u.Email == email && u.Password == password);
            return userFound;
        }

        public User GetUserByUsernameAndPassword(string username, string password)
        {
            User userFound = context.Users.SingleOrDefault(u => u.Username == username && u.Password == password);
            return userFound;
        }

        public List<User> GetUsersIsActive(bool isActive,int offset, int size)
        {
            List<User> usersFound = (List<User>)context.Users.Where(u => u.IsActive == isActive).Skip(offset).Take(size);
            return usersFound;
        }

        public List<User> GetAllUsers(int offset, int size)
        {
            List<User> usersFound = (List<User>)context.Users.Skip(offset).Take(size);
            return usersFound;
        }

        public User Save(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
            return user;
        }

        public User Update(User user)
        {
            context.Entry(user).State = System.Data.EntityState.Modified;
            context.SaveChanges();
            return user;
        }
    }
}