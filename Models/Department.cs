namespace MyProject.Models
{
	public class Department
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int capacity { get; set; }
		List<Student> students { get; set; }
 	}
}
