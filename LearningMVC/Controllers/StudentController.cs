using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearningMVC.Models;
using LearningMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace LearningMVC.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public IActionResult Index()
        {
            var students = _studentService.GetStudent();

            return View(students);
        }
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Edit(int studentId)
        {
            Student student = _studentService.GetStudentById(studentId);
            return View(student);
        }
        public IActionResult Delete(int studentId)
        {
            _studentService.DeleteStudent(studentId);
            return RedirectToAction("Index");
        }
        public IActionResult SaveStudent(Student student)
        {
            if (student.Id == 0) {
                _studentService.AddNewStudent(student);
            } else {
                _studentService.EditStudent(student);
            }
            return RedirectToAction("Index");
        }
    }
}