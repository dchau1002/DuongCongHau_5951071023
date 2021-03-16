using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Student.Models;

namespace Student.Controllers
{
    public class StudentController : ApiController
    {
        // GET: api/Student
        public IEnumerable<StudentInfor> Get()
        {
            var studentInfList = new List<StudentInfor>();
            var StudentInfor = new StudentInfor
            {
                MSSV = "5951071023",
                HoTen = "Duong Cong Hau",
                Lop = "Cong nghe thong tin K59"
            };
            studentInfList.Add(StudentInfor);
            return studentInfList;
        }

        // GET: api/Student/5
        public StudentInfor Get(int id)
        {
            return new StudentInfor
            {
                MSSV = "5951071023",
                HoTen = "Duong Cong Hau",
                Lop = "Cong nghe thong tin K59"
            };
        }
    }
}
