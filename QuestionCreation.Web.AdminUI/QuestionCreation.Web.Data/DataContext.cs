using QuestionCreation.Web.Data.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace QuestionCreation.Web.Data
{
    public class DataContext : DbContext
    {
        public static DataContext Create()
        {
            return new DataContext();
        }

        public DataContext() :  base("DataContext")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Answer> AdminPages { get; set; }

    }
}
