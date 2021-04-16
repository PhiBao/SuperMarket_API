using System.Collections.Generic;
using System.Linq;
using LearningMVC.Models;

namespace LearningMVC.Services
{
    public class StudentService : IStudentService
    {
        private readonly DataContext _context;
        public StudentService(DataContext context) 
        {
            _context = context;
        }

        public List<Student> GetStudent()
        {
            return _context.Students.ToList();
        }

        public Student GetStudentById(int studentId)
        {
            return _context.Students.FirstOrDefault(s => s.Id == studentId);
        }        
        public void AddNewStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public void DeleteStudent(int studentId)
        {
            var student = GetStudentById(studentId);
            if (student == null) return;
            _context.Students.Remove(student);
            _context.SaveChanges();
        }

        public void EditStudent(Student student)
        {
            var studentSelected = GetStudentById(student.Id);
            if (studentSelected == null) return;
            studentSelected.Name = student.Name;
            studentSelected.Age = student.Age;
            studentSelected.Address = student.Address;
            _context.SaveChanges();
        }
    }
}