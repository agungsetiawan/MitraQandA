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
            User userAgung=new User() {
                FirstName="Agung",
                LastName="Setiawan",
                Email="com.agungsetiawan@gmail.com",
                Username="agungsetiawan",
                Password="password",
                IsActive=true,
                IsOnline=true,
                Roles=Roles
            };
            context.Users.Add(userAgung);


            List<Tag> tags = new List<Tag>();
            Tag TagJava = new Tag() {Name="Java" };
            Tag TagCSharp = new Tag() { Name = "C#" };
            tags.Add(TagJava);
            tags.Add(TagCSharp);
            context.Tags.Add(TagJava);
            context.Tags.Add(TagCSharp);


            List<Answer> answers = new List<Answer>();
            Answer answerOne = new Answer()
            {
                Content = "Using jdbc will be good for starting",
                Point = 1,
                User = userAgung
            };
            Answer answerTwo = new Answer()
            {
                Content = "Using Spring jdbc will be easier",
                Point = 1,
                User = userAgung
            };
            answers.Add(answerOne);
            context.Answers.Add(answerOne);
            answers.Add(answerTwo);
            context.Answers.Add(answerTwo);


            Question questionJava = new Question()
            {
                Title="How to Java MySql",
                Body="I want to know how to connect Java with MySql",
                PublishedDate=DateTime.Now,
                Tags=tags,
                User=userAgung,
                Answer=answers
            };
            context.Questions.Add(questionJava);


            //All standards will
            base.Seed(context);
        }
    }
}