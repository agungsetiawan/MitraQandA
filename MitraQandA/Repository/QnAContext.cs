using MitraQandA.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MitraQandA.Repository
{
    public class QnAContext : DbContext
    {
        public QnAContext() : base("QnAConnection")
        {
            Database.SetInitializer<QnAContext>(new QnAInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<User>()
            //            .HasRequired(u => u.Questions)
            //            .WithMany()
            //            .WillCascadeOnDelete(false);

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Question> Questions { get; set; }
    }
}