using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class PersonContext : DbContext
    {
        public PersonContext(DbContextOptions<PersonContext> options) : base(options)
        {
        }

        //EF implicitly includes the othe models because they're all referenced by Person so no need DbSets for the others
        public DbSet<Person> Persons { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Genders> Genders { get; set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Auto-generating value for TimeCreated each time a Post as been added
            modelBuilder.Entity<Post>()
                .Property(p => p.TimeCreated)
                .HasDefaultValueSql("getdate()");
               
            //Auto-generating value for TimeCreated each time a Comment as been added
               modelBuilder.Entity<Comment>()
                .Property(c => c.TimeCreated)
                .HasDefaultValueSql("getdate()");

            //Default value for Gender in case none is specified
            modelBuilder.Entity<Genders>()
                .Property(g => g.Gender)
                .HasDefaultValue("U"); //U for unkown gender

            modelBuilder.Entity<Person>()
                .HasIndex(p => new { p.Username, p.Password });
        }

    }
}
