using ListSvIntern.Data;
using ListSvIntern.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ListSvIntern.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentContext _student;

        public StudentController(StudentContext student)
        {
            _student = student;
        }

        [HttpGet]

        public async Task<ActionResult<List<Student>>> GetStudent()
        {
            return Ok(await _student.Students.ToArrayAsync());
        }

        [HttpPost]

        public async Task<ActionResult<Student>> AddStudent(Student stu)
        {
            _student.Students.Add(stu);

            await _student.SaveChangesAsync();

            return Ok(await _student.Students.ToArrayAsync());
        }

        [HttpGet("{msv}")]

        public async Task<ActionResult<Student>> GetStudentBy(int msv)
        {
            var oldstu = await _student.Students.FirstOrDefaultAsync(m => m.Msv == msv);

            if (oldstu == null)
            {
                return BadRequest("Student not found");

            }

            return Ok(oldstu);
        }



        [HttpPut("{msv}")]

        public async Task<ActionResult<List<Student>>> Update(Student stu, int msv)
        {
            var oldstu = await _student.Students.FirstOrDefaultAsync(m => m.Msv == msv);

            if(oldstu == null)
            {
                return BadRequest("Student not found to Update");
            }
            else
            {
                oldstu.Name = stu.Name;
                oldstu.DateBirth = stu.DateBirth;
                oldstu.Khoa = stu.Khoa;
                
            }
            await _student.SaveChangesAsync();
            return Ok(await _student.Students.ToArrayAsync());

        }

        [HttpDelete("{msv}")]

        public async Task<ActionResult<Student>> DelStudent(int msv)
        {
            var delStudent = await _student.Students.FirstOrDefaultAsync(m => m.Msv == msv);

            _student.Students.Remove(delStudent);

            await _student.SaveChangesAsync();

            return Ok(await _student.Students.ToArrayAsync());
        }


    }
}
