using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ClassLibraryTrainingCourses.DAL.Entities;
using ClassLibraryTrainingCourses.DAL.Interfaces;

namespace ClassLibraryTrainingCourses.DAL.DAO
{
    public class CourseDAO : BaseDAO, ICourseDAO
    {
        private const string SELECT_ALL_COURSE = "SELECT * FROM Course ORDER BY name";
        private const string DELETE_COURSE = "DELETE FROM Course WHERE id = @id";
        private const string ADD_COURSE = "INSERT INTO Course(name, cost) VALUES(@name, @cost)";
        private const string UPDATE_COURSE = "UPDATE Course SET name = @name, cost = @cost WHERE id = @id";
        private const string FIND_MOST_EXPENSIVE = "SELECT c.* FROM Course c WHERE c.cost = (SELECT MAX(c.cost) FROM Course c)";
        private const string FIND_MOST_CHEAPEST = "SELECT c.* FROM Course c WHERE c.cost = (SELECT MIN(c.cost) FROM Course c)";
        private const string FIND_MOST_PROFITABLE = "DECLARE @CoursesWithSumCost TABLE (id int, [name] nvarchar(50), cost money, sum_cost money) " +
                    "INSERT @CoursesWithSumCost( id, [name], cost, sum_cost) SELECT c.id, c.name, c.cost, COUNT(1) * c.cost as sum_cost FROM Student s JOIN Course c ON s.course_id = c.id " +
                    "GROUP BY c.id, c.name, c.cost SELECT c.* FROM @CoursesWithSumCost c WHERE c.sum_cost = (SELECT MAX(c.sum_cost) FROM @CoursesWithSumCost c)";
        private const string COUNT_TO_ID = "SELECT count(2) FROM Student where course_id = @course_id";
        private const string COUNT_COURSES = "SELECT count(1) FROM Course";

        public void Add(Course course)
        {
            try
            {
                Connection.Open();
                SqlCommand command = new SqlCommand(ADD_COURSE, Connection);

                SqlParameter nameParam = new SqlParameter("@name", course.Name);
                SqlParameter costParam = new SqlParameter("@cost", course.CourseCost);

                command.Parameters.Add(nameParam);
                command.Parameters.Add(costParam);

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

                SqlCommand command = new SqlCommand(DELETE_COURSE, Connection);

                SqlParameter idParam = new SqlParameter("@id", id);

                command.Parameters.Add(idParam);
                command.ExecuteNonQuery();
            }
            finally
            {
                Connection.Close();
            }
        }

        public List<Course> GetAllByOrder()
        {
            List<Course> courses = new List<Course>();

            try
            {
                Connection.Open();
                SqlCommand command = new SqlCommand(SELECT_ALL_COURSE, Connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Course course = new Course();
                        course.Id = reader.GetInt32(0);
                        course.Name = reader.GetString(1);
                        course.CourseCost = reader.GetDecimal(2);
                        courses.Add(course);
                    }
                }
            }
            finally
            {
                Connection.Close();
            }


            return courses;
        }

        public void Update(int id, Course course)
        {
            try
            {
                Connection.Open();
                SqlCommand command = new SqlCommand(UPDATE_COURSE, Connection);

                SqlParameter nameParam = new SqlParameter("@name", course.Name);
                SqlParameter costParam = new SqlParameter("@cost", course.CourseCost);
                SqlParameter idParam = new SqlParameter("@id", course.Id);

                command.Parameters.Add(nameParam);
                command.Parameters.Add(costParam);
                command.Parameters.Add(idParam);

                command.ExecuteNonQuery();
            }
            finally
            {
                Connection.Close();
            }
        }

        public List<Course> MostExpensive()
        {
            List<Course> courses = new List<Course>();

            try
            {
                Connection.Open();
                SqlCommand command = new SqlCommand(FIND_MOST_EXPENSIVE, Connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Course course = new Course();
                        course.Id = reader.GetInt32(0);
                        course.Name = reader.GetString(1);
                        course.CourseCost = reader.GetDecimal(2);
                        courses.Add(course);
                    }
                }
            }
            finally
            {
                Connection.Close();
            }

            return courses;
        }

        public List<Course> MostCheapest()
        {
            List<Course> courses = new List<Course>();

            try
            {
                Connection.Open();
                SqlCommand command = new SqlCommand(FIND_MOST_CHEAPEST, Connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Course course = new Course();
                        course.Id = reader.GetInt32(0);
                        course.Name = reader.GetString(1);
                        course.CourseCost = reader.GetDecimal(2);
                        courses.Add(course);
                    }
                }
            }
            finally
            {
                Connection.Close();
            }

            return courses;
        }

        public List<Course> MostProfitable()
        {
            List<Course> courses = new List<Course>();

            try
            {
                Connection.Open();
                SqlCommand command = new SqlCommand(FIND_MOST_PROFITABLE, Connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Course course = new Course();
                        course.Id = reader.GetInt32(0);
                        course.Name = reader.GetString(1);
                        course.CourseCost = reader.GetDecimal(2);
                        courses.Add(course);
                    }
                }
            }
            finally
            {
                Connection.Close();
            }

            return courses;
        }

        public int GetCountToId(int id)
        {
            int count = 0;

            try
            {
                Connection.Open();

                SqlCommand command = new SqlCommand(COUNT_TO_ID, Connection);

                SqlParameter courseIdParam = new SqlParameter("@course_id", id);
                command.Parameters.Add(courseIdParam);

                count = Convert.ToInt32(command.ExecuteScalar());
            }
            finally 
            {
                Connection.Close();
            }

            return count;
        }

        public int GetCount()
        {
            int count = 0;

            try
            {
                Connection.Open();
                SqlCommand command = new SqlCommand(COUNT_COURSES, Connection);

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
