using WebAppTW.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace WebAppTW.DAL
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("SchoolContext") { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // esse cara deve criar a base, mas não tinha no código original então removi.
            //base.OnModelCreating(modelBuilder);
            
            //Acho que esse cara aqui remove a base de dados caso encontre alguma divergencia :S 
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
        }


    }
}