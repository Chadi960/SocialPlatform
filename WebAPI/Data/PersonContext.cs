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

            modelBuilder.Entity<Post>()
                .Property(p => p.TimeCreated)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Comment>()
                .Property(c => c.TimeCreated)
                .HasDefaultValueSql("getdate()");





            modelBuilder.Entity<Genders>()
                .Property(g => g.Gender)
                .HasDefaultValue("M");

            modelBuilder.Entity<Genders>()
                .Property(g => g.Gender)
                .HasDefaultValue("F");
        }

    }
}
