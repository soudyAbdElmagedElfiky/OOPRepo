using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MyProject.Models
{
	public class ApplicationDbContext:DbContext
	{
	   public DbSet<Student> students {  get; set; }
		public DbSet<Department> department { get; set; }
        public ApplicationDbContext()
        {
            
        }
        public ApplicationDbContext(DbContextOptions options):base(options)
		{ 

		}
		//protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		//{
		//	//base.OnConfiguring(optionsBuilder);
		//	optionsBuilder.UseSqlServer("CS");
		//}
	}
}
