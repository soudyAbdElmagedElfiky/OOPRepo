namespace MyProject.Models
{
	public class Student
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public byte age { get; set; }
		public  int DepartmentId { get; set; }
		public Department department { get; set; }
	}
}
