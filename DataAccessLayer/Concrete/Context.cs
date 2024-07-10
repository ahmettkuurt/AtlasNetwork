using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context :DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=AHMET\\SQLEXPRESS;Initial Catalog=AtlasNetworkDB;Integrated Security=True;TrustServerCertificate=True;");


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<MainPage> MainPages { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<References> References { get; set; }
        public DbSet<Contact> Contacts { get; set; }


    }
}
