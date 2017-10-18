namespace MVCInClassDemo.DAL
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using MVCInClassDemo.Models;

    public class EFDemoDBContext : DbContext
    {

        public virtual DbSet<Student> Students { get; set; }

        public virtual DbSet<UnderGradLevel> UnderGradLevels { get; set; }


        public EFDemoDBContext()
            : base("name=UniversityDB")
        {

            Database.SetInitializer(new UniversityDBInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Configure domain classes using modelBuilder here
            
            //Student configuration
            modelBuilder.Entity<Student>().HasKey<int>(s => s.StudentID);

            
            modelBuilder.Entity<Student>()
            .HasRequired<UnderGradLevel>(s => s.UnderGradLevel)
            .WithMany(g => g.Students);


            base.OnModelCreating(modelBuilder);
        }

    }

}
