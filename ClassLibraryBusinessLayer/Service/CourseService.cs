using System.Collections.Generic;
using ClassLibraryBusinessLayer.Model;
using ClassLibraryTrainingCourses.DAL.DAO;
using ClassLibraryTrainingCourses.DAL.Entities;

namespace ClassLibraryBusinessLayer.Service
{
    public class CourseService
    {
        public void AddCourse(string name, decimal cost)
        {
            CourseDAO course = new CourseDAO();
            Course newCourse = new Course(name, cost);
            course.Add(newCourse);
        }

        public void DeleteCourse(int id)
        {
            CourseDAO course = new CourseDAO();
            course.Delete(id);
        }

        public void EditCourse(int id, string name, decimal cost)
        {
            CourseDAO course = new CourseDAO();
            Course newCourse = new Course(name, cost, id);
            course.Update(id, newCourse);
        }

        public List<AdvancedCourseModel> MostProfitableCourses()
        {
            List<AdvancedCourseModel> mostProfCourses = new List<AdvancedCourseModel>();

            CourseDAO course = new CourseDAO();
            List<Course> coursesProf = course.MostProfitable();

            foreach (Course courseP in coursesProf)
            {
                AdvancedCourseModel newCourse = new AdvancedCourseModel();
                newCourse.Id = courseP.Id;
                newCourse.Name = courseP.Name;
                newCourse.Cost = courseP.CourseCost;
                newCourse.SumCost = course.GetCountToId(newCourse.Id) * newCourse.Cost;
                mostProfCourses.Add(newCourse);
            }

            return mostProfCourses;
        }

        public List<CourseModel> MostExpensiveCourse()
        {
            List<CourseModel> mostExpCourses = new List<CourseModel>();

            CourseDAO course = new CourseDAO();
            List<Course> coursesExp = course.MostExpensive();

            foreach (Course courseExp in coursesExp)
            {
                CourseModel newCourse = new CourseModel();
                newCourse.Id = courseExp.Id;
                newCourse.Name = courseExp.Name;
                newCourse.Cost = courseExp.CourseCost;
                mostExpCourses.Add(newCourse);
            }

            return mostExpCourses;
        }

        public List<CourseModel> MostCheapestCourse()
        {
            List<CourseModel> mostExpCourses = new List<CourseModel>();

            CourseDAO course = new CourseDAO();
            List<Course> coursesCheap = course.MostCheapest();

            foreach (Course courseExp in coursesCheap)
            {
                CourseModel newCourse = new CourseModel();
                newCourse.Id = courseExp.Id;
                newCourse.Name = courseExp.Name;
                newCourse.Cost = courseExp.CourseCost;
                mostExpCourses.Add(newCourse);
            }

            return mostExpCourses;
        }

        public List<CourseModel> AllCourses()
        {
            List<CourseModel> listCourses = new List<CourseModel>();

            CourseDAO course = new CourseDAO();
            List<Course> allCourses = course.GetAllByOrder();

            foreach (Course cour in allCourses)
            {
                CourseModel newCourse = new CourseModel();
                newCourse.Id = cour.Id;
                newCourse.Name = cour.Name;
                newCourse.Cost = cour.CourseCost;
                listCourses.Add(newCourse);
            }

            return listCourses;
        }

        public int CountCourses()
        {
            int count = 0;

            CourseDAO course = new CourseDAO();
            count = course.GetCount();

            return count;
        }
    }
}
