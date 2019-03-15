using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace denizdikbiyik_CET322_HW1.Models
{
    public class Student
    {
        public int Id { get; set; }
        public decimal StudentNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public decimal TelNo { get; set; }

        //aşağısı ekstra:
        public Student ToStudent()
        {
            return new Student
            {
                Name = this.Name,
                Surname = this.Surname,
                StudentNo = this.StudentNo,
                Email = this.Email,
                TelNo = this.TelNo
            };
        }
        public void ImportFromStudent(Student student)
        {
            this.Name = student.Name;
            this.Surname = student.Surname;
            this.StudentNo = student.StudentNo;
            this.Email = student.Email;
            this.TelNo = student.TelNo;
        }
        //
    }
}
