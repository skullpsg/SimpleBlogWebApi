using SimpleBlogWebApi.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace SimpleBlogWebApi.Controllers
{
    public class StudentController : ApiController
    {
        private List<Student> studentList = new List<Student>();

        public StudentController()
        {
            studentList.Add(new Student() { id = "1", Name = "vishnu", sex = PersonSex.male, Address = "coimbatore,India", standard = "10th" });
            studentList.Add(new Student() { id = "2", Name = "sangeetha", sex = PersonSex.female, Address = "coimbatore,India", standard = "10th" });
            studentList.Add(new Student() { id = "3", Name = "sachin", sex = PersonSex.male, Address = "coimbatore,India", standard = "10th" });
            studentList.Add(new Student() { id = "4", Name = "Tendulkar", sex = PersonSex.male, Address = "coimbatore,India", standard = "10th" });
            studentList.Add(new Student() { id = "5", Name = "Arun", sex = PersonSex.male, Address = "coimbatore,India", standard = "10th" });
        }

        [HttpGet]
        [ActionName("StudentList")]
        public List<Student> GetStudentList()
        {
            return studentList;
        }

        [HttpGet]
        [ActionName("GetStudentById/{id}")]
        public IEnumerable<Student> GetStudentById(string id)
        {
            return studentList.Where(stud => stud.id == id);
        }
    }
}