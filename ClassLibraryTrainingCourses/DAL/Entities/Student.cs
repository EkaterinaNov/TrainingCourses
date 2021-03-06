namespace ClassLibraryTrainingCourses.DAL.Entities
{
    public class Student : Entity
    {
        public int CourseId { get; set; }
        public Course Course { get; set; }

        public Student()
        {
            Course = new Course();
        }

        public Student (string studentName, int courseId, int id = 0) : base(id, studentName)
        {
            CourseId = courseId;
            Course = new Course();
        }

        public override string ToString()
        {
            return Name + "(course id = " + CourseId + ")";
        }
    }
}
