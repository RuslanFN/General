using AppTeam101.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace AppTeam101.DAL
{
    public class DBContext : DbContext
    {
        public DBContext() : base("DefaultConnection")
        { }
        public DbSet<Events> Events { get; set; }
        public DbSet<News> News { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

       // public System.Data.Entity.DbSet<AppTeam101.Models.News> News { get; set; }
    }
}