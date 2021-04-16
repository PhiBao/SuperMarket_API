using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearningMVC.Models;

namespace LearningMVC.Services
{
    public interface IStudentService
    {
        List<Student> GetStudent();
        Student GetStudentById(int studentId);
        void AddNewStudent(Student student);
        void EditStudent(Student student);
        void DeleteStudent(int studentID);
    }
}