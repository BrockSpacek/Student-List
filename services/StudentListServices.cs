using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Student_List.Models;

namespace Student_List.services
{
    public class StudentListServices
    {
        public List<StudentModel> studentList = new();

        public StudentListServices()
        {
            studentList.Add(new StudentModel {
                Id = 0,
                Name = "Charles"
            });
        }

        
        public List<StudentModel> GetStudents()
        {
            return studentList;
        }


        public List<StudentModel> AddToStudentList(string studentToAdd)
        {
            StudentModel student = new();
            student.Name = studentToAdd;

            studentList.Add(student);
            return studentList;
        }


        public List<StudentModel> RemoveFromStudentList(string studentToRemove)
        {
            StudentModel student = studentList.Find(student => student.Name == studentToRemove);
            studentList.Remove(student);
            return studentList;
        }
        

        public List<StudentModel> EditStudentFromList(string studentToEdit, string newStudentName)
        {
            int index = studentList.FindIndex(student => student.Name == studentToEdit);
           
            studentList[index].Name = newStudentName;
            return studentList;
        }
    }
}