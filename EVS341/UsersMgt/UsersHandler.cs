﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVS341.UsersMgt
{
    public class UsersHandler
    {
        public List<User> GetUsers()
        {
            GarmentsContext context = new GarmentsContext();            
            using (context)
            {
                return (from u in context.Users
                        .Include("Role")
                        .Include("Address.City.Province.Country")
                        select u).ToList();                
            }
        }

        public User GetUser(string loginid, string password)
        {
            using (GarmentsContext context = new GarmentsContext())
            {
                return (from u in context.Users
                        .Include("Role")
                        .Include("Address.City.Province.Country")
                        where u.LoginId.Equals(loginid) && u.Password.Equals(password)
                        select u).FirstOrDefault();
            }
        }


        public List<Role> GetRoles()
        {
            GarmentsContext context = new GarmentsContext();
            using (context)
            {
                return (from u in context.Roles
                        select u).ToList();
            }
        }

        public void AddUser(User user)
        {
            using (GarmentsContext context = new GarmentsContext())
            {
                user.Role = context.Roles.Find(2);

                user.Role = new Role { Id = 2 };
                context.Entry(user.Role).State = System.Data.Entity.EntityState.Unchanged;

                context.Users.Add(user);
                context.SaveChanges();
            }
        }

    }
}
