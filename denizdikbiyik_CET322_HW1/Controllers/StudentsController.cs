using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using denizdikbiyik_CET322_HW1.Models;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace denizdikbiyik_CET322_HW1.Controllers
{
    public class StudentsController : Controller
    {
        StudentsContext studentsContext;
        public StudentsController(StudentsContext context)
        {
            studentsContext = context;
        }
        public IActionResult Index()
        {
            var students = studentsContext.Students.ToList();
            return View(students);
        }
        public IActionResult Detay(int id)
        {
            Student student = studentsContext.Students.Where(s => s.Id == id).FirstOrDefault();
            if (student != null)
            {
                return View(student);
            }
            else
            {
                return NotFound();
            }
        }
        [HttpPost]
        public IActionResult Detay(Student student)
        {
            var editStudent = studentsContext.Students.Where(s => s.Id == student.Id).FirstOrDefault();
            editStudent.Name = student.Name;
            editStudent.Surname = student.Surname;
            editStudent.StudentNo = student.StudentNo;
            editStudent.Email = student.Email;
            editStudent.TelNo = student.TelNo;
            studentsContext.SaveChanges();
            return View(editStudent);
        }
        [HttpGet]
        public IActionResult Add(Student student)
        {
            return View(student);
        }
        [HttpPost]
        public IActionResult AddPost(Student student)
        {
            var newStudent = new Student();
            newStudent.Name = student.Name;
            newStudent.Surname = student.Surname;
            newStudent.StudentNo = student.StudentNo;
            newStudent.Email = student.Email;
            newStudent.TelNo = student.TelNo;
            studentsContext.Add(newStudent);
            studentsContext.SaveChanges();
            return RedirectToAction("Add");
        }
        //
    }
}