using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.Models;

namespace MyProject.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DepartmentController : ControllerBase
	{
		private readonly ApplicationDbContext _context;
		public DepartmentController(ApplicationDbContext context)
		{
			_context = context;
		}
		[HttpGet]
		public IActionResult Get()
		{
			List<Department> departmentList = _context.department.ToList();
			return Ok(departmentList);
		}
		[HttpGet("{id}")]
		public IActionResult GetById(int id)
		{

			return Ok(_context.department.FirstOrDefault(x => x.Id == id));
		}
		[HttpPost]
		public IActionResult Add(Department department)
		{
			_context.department.Add(department);
			_context.SaveChanges();
			//Department d = department;
			return Ok(department);
		}
		[HttpPut]
		public IActionResult Update(int id,Department department)
		{
			Department oldDept = _context.department.FirstOrDefault(D => D.Id == id);
			department.Id = id;
			oldDept.Name = department.Name;
			oldDept.capacity = department.capacity;
			_context.SaveChanges();
			return Ok(department);
		}
		[HttpDelete]
		public IActionResult Remove(int id)
		{
			Department dp = _context.department.FirstOrDefault(S => S.Id == id);
			_context.department.Remove(dp);
			_context.SaveChanges();

			return Ok();
		}
	}
}
