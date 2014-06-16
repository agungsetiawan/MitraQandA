using MitraQandA.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MitraQandA.Repository
{
    public class QnAInitializer : DropCreateDatabaseAlways<QnAContext>
    {
        protected override void Seed(QnAContext context)
        {
            List<Role> Roles = new List<Role>();

            Role RoleAdministrator=new Role() { Name = "Administrator" };
            Role RoleUser=new Role() { Name = "User" };

            Roles.Add(RoleAdministrator);
            Roles.Add(RoleUser);

            context.Roles.Add(RoleAdministrator);
            context.Roles.Add(RoleUser);


            List<User> Users = new List<User>();

            Users.Add(new User() {
                FirstName="Agung",
                LastName="Setiawan",
                Email="com.agungsetiawan@gmail.com",
                Username="agungsetiawan",
                Password="password",
                IsActive=true,
                Roles=Roles
            });

            //All standards will
            base.Seed(context);
        }
    }
}