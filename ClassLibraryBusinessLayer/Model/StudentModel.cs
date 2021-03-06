namespace ClassLibraryBusinessLayer.Model
{
    public class StudentModel : BaseModel
    {
        public int CourseId { get; set; }
        public CourseModel Course { get; set; }

        public StudentModel()
        {
            Course = new CourseModel();
        }

        public StudentModel(int id, string studentName, int courseId) : base(id, studentName)
        {
            CourseId = courseId;
            Course = new CourseModel();
        }

        public override string ToString()
        {
            return Name + "(course id = " + CourseId + ")";
        }
    }
}
