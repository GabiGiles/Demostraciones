using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebAPIDemo.Models;

namespace WebAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private List<Student> students()
        {
            List<Student> studentsLocal = new List<Student>()
            { 
                new Student(){ Id=1, LastName="Pint", Name="Gustavo" },
                new Student(){ Id=2, LastName="Red", Name="Cecilia" },
                new Student(){ Id=3, LastName="Perez", Name="Lucas" } 
            };

            return studentsLocal;
        }

        // GET: /api/student/
        [HttpGet]
        public IEnumerable<Student> GetListar()
        {
            return students();
        }

        // GET: /api/student/id
        [HttpGet("{id}")]
        public Student Get(int id) 
        {
            Student student= students().Find(x => x.Id == id);
            return student;
        }


    }
}
