using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team_Golf.Models;
using Microsoft.EntityFrameworkCore;


namespace Team_Golf
{
    public class GolfCourseContext : DbContext
    {
        public DbSet<GolfCourse> GolfCourses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=GolfCourseDatabase;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<GolfCourse>().HasData(
                
               new GolfCourse("Bushwood CC", 1, "Good snack shack and poor caddying","Bushwood.jpg"),
               new GolfCourse("Fury Creek Golf CC", 2, "Price is wrong B&$#%","FurryCreek.jpg"),
               new GolfCourse("Cotton Wood", 3, "Waggle and let the big dog eat","Cottonwood.jpg"),
               new GolfCourse("Little Met",4,"Great course for beginners, not so much for the advanced player","golfcouse5.jpg")
               );
        }
    }
}
