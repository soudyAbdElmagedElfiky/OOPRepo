using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.Models;

namespace MyProject.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class StudentController : ControllerBase
	{
		private readonly ApplicationDbContext _context;
		public StudentController(ApplicationDbContext context)
		{
			_context = context;
		}
		[HttpGet]
		public IActionResult Get()
		{
			List<Student> StudentList = _context.students.ToList();
			return Ok(StudentList);
		}
		[HttpGet("{id}")]
		public IActionResult GetById(int id)
		{

			return Ok(_context.students.FirstOrDefault(x => x.Id == id));
		}
		[HttpPost]
		public IActionResult Add(Student student)
		{
			_context.students.Add(student);
			_context.SaveChanges();
			//Department d = department;
			return Ok(student);
		}
		[HttpPut]
		public IActionResult Update(int id, Student student )
		{
			Student OldStud = _context.students.FirstOrDefault(D => D.Id == id);
			student .Id = id;
			OldStud.Name = student.Name;
			OldStud.age = student.age;
			OldStud.Address = student.Address;
			_context.SaveChanges();
			return Ok(student);
		}
		[HttpDelete]
		public IActionResult Remove(int id)
		{
			 Student st=_context.students.FirstOrDefault(S => S.Id == id);
			_context.students.Remove(st);
			_context.SaveChanges();

			return Ok();
		}
	}
}
