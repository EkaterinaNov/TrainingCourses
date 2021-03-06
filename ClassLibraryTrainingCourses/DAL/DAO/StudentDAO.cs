using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ClassLibraryTrainingCourses.DAL.Entities;
using ClassLibraryTrainingCourses.DAL.Interfaces;

namespace ClassLibraryTrainingCourses.DAL.DAO
{
    public class StudentDAO : BaseDAO, IStudentDAO
    {
        private const string SELECT_ALL_STUDENT = "SELECT c.*, s.* FROM Student s JOIN Course c ON s.course_id = c.id ORDER BY c.name, s.name";
        private const string ADD_STUDENT = "INSERT INTO Student (name, course_id) VALUES (@name, @course_id)";
        private const string DELETE_STUDENT = "DELETE FROM Student WHERE id = @id";
        private const string UPDATE_STUDENT = "UPDATE Student SET name = @name, course_id = @course_id WHERE id = @id";
        private const string COUNT_STUDENTS = "SELECT count(1) FROM Student";

        public void Add(Student student)
        {
            try
            {
                Connection.Open();
                SqlCommand command = new SqlCommand(ADD_STUDENT, Connection);

                SqlParameter nameParam = new SqlParameter("@name", student.Name);
                SqlParameter courseIdParam = new SqlParameter("@course_id", student.CourseId);

                command.Parameters.Add(nameParam);
                command.Parameters.Add(courseIdParam);

                command.ExecuteNonQuery();
            }
            finally
            {
                Connection.Close();
            }
        }

        public void Delete(int id)
        {
            try
            {
                Connection.Open();

                SqlCommand command = new SqlCommand(DELETE_STUDENT, Connection);

                SqlParameter idParam = new SqlParameter("@id", id);

                command.Parameters.Add(idParam);
                command.ExecuteNonQuery();
            }
            finally
            {
                Connection.Close();
            }
        }

        public void Update(int id, Student student)
        {
            try
            {
                Connection.Open();
                SqlCommand command = new SqlCommand(UPDATE_STUDENT, Connection);

                SqlParameter nameParam = new SqlParameter("@name", student.Name);
                SqlParameter courseIdParam = new SqlParameter("@course_id", student.CourseId);
                SqlParameter idParam = new SqlParameter("@id", student.Id);

                command.Parameters.Add(nameParam);
                command.Parameters.Add(courseIdParam);
                command.Parameters.Add(idParam);

                command.ExecuteNonQuery();
            }
            finally
            {
                Connection.Close();
            }
        }

        public List<Student> GetAllByOrder()
        {
            List<Student> students = new List<Student>();

            try
            {
                Connection.Open();

                SqlCommand command = new SqlCommand(SELECT_ALL_STUDENT, Connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Student student = new Student();
                        student.CourseId = reader.GetInt32(0);
                        student.Course.Name = reader.GetString(1);
                        student.Course.CourseCost = reader.GetDecimal(2);
                        student.Id = reader.GetInt32(3);
                        student.Name = reader.GetString(4);
                        student.CourseId = reader.GetInt32(5);
                        students.Add(student);
                    }
                }
            }
            finally
            {
                Connection.Close();
            }
            
            return students;
        }

        public int GetCount()
        {
            int count = 0;

            try
            {
                Connection.Open();
                SqlCommand command = new SqlCommand(COUNT_STUDENTS, Connection);

                count = Convert.ToInt32(command.ExecuteScalar());
            }
            finally
            {
                Connection.Close();
            }

            return count;
        }
    }
}
