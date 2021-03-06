using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryBusinessLayer.Model;
using ClassLibraryTrainingCourses.DAL.DAO;
using ClassLibraryTrainingCourses.DAL.Entities;

namespace ClassLibraryBusinessLayer.Service
{
    public class StudentService
    {
        public List<StudentModel> AlphabeticalOrderByCourse()
        {
            List<StudentModel> studentList = new List<StudentModel>();

            StudentDAO st = new StudentDAO();
            List<Student> stList = st.GetAllByOrder();

            foreach (Student student in stList)
            {
                StudentModel studentModel = new StudentModel();
                studentModel.Id = student.Id;
                studentModel.Name = student.Name;
                studentModel.CourseId = student.CourseId;
                studentModel.Course.Id = student.Course.Id;
                studentModel.Course.Name = student.Course.Name;
                studentModel.Course.Cost = student.Course.CourseCost;
                studentList.Add(studentModel);
            }
            
            return studentList;
        }

        public void AddStudent(string name, int courseId)
        {
            Student newStudent = new Student(name, courseId);
            StudentDAO newSt = new StudentDAO();
            newSt.Add(newStudent);
        }

        public void EditStudent(int id, string name, int courseId)
        {
            Student student = new Student(name, courseId, id);

            StudentDAO st = new StudentDAO();
            st.Update(id, student);
        }

        public void DeleteStudent(int id)
        {
            StudentDAO st = new StudentDAO();
            st.Delete(id);
        }

        public int CountStudents()
        {
            int count = 0;

            StudentDAO st = new StudentDAO();
            count = st.GetCount();

            return count;
        }
    }
}
