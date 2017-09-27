using Contrucks.model;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace Contrucks.Repository
{
    public class ConTruckContext : IdentityDbContext 
    {   
        public ConTruckContext() : base("ConTruckConnectionString")
        {
        }
        public DbSet<Contractors> Contractors { get; set; }
        public DbSet<Truckers> Truckers { get; set; }
        public DbSet<TruckerDetail> TruckerDetail { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<UserTables> UserTables { get; set; }
        public DbSet<NewJobPosts> NewJobPosts { get; set; }
        public DbSet<JobApplications> JobApplications { get; set; }
        public DbSet<JobDuration> JobDuration { get; set; }
        public DbSet<Messages> Messages { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<LoadTypes> LoadTypes { get; set; }
        public DbSet<Transactions> Transactions { get; set; }
        public DbSet<Balance> Balance { get; set; }
        public DbSet<Ratings> Ratings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<State>().HasMany(t => t.Contractors).WithRequired(a => a.State).WillCascadeOnDelete(false); //add this line code
            modelBuilder.Entity<City>().HasMany(t => t.Contractors).WithRequired(a => a.City).WillCascadeOnDelete(false); //add this line code
            modelBuilder.Entity<City>().HasMany(t => t.Truckers).WithRequired(a => a.City).WillCascadeOnDelete(false); //add this line code
            modelBuilder.Entity<State>().HasMany(t => t.Truckers).WithRequired(a => a.State).WillCascadeOnDelete(false); //add this line code

        }

        public virtual void Commit()
        {
            base.SaveChanges();
        }
    }
}
