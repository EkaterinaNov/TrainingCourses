namespace ClassLibraryTrainingCourses.DAL.Entities

{
    public class Course : Entity
    {
        public decimal CourseCost { get; set; }
        
        public Course() { }

        public Course (string courseName, decimal courseCoast, int id = 0) : base(id, courseName)
        {
            CourseCost = courseCoast;
        }

        public override string ToString()
        {
            return Name + " (coast = " + CourseCost + ")";
        }
    }
}
