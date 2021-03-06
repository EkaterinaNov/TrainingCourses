namespace ClassLibraryBusinessLayer.Model
{
    public class CourseModel : BaseModel
    {
        public decimal Cost { get; set; }

        public CourseModel() { }

        public CourseModel(int id, string courseName, decimal courseCoast) : base(id, courseName)
        {
            Cost = courseCoast;
        }

        public override string ToString()
        {
            return Name + " (coast = " + Cost + ")";
        }
    }
}
