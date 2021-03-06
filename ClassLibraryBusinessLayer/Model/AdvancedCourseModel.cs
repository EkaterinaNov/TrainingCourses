namespace ClassLibraryBusinessLayer.Model
{
    public class AdvancedCourseModel : CourseModel
    {
        public decimal SumCost { get; set; }

        public AdvancedCourseModel() { }

        public AdvancedCourseModel(int id, string courseName, decimal courseCoast, decimal sumCost) : base(id, courseName, courseCoast)
        {
            SumCost = sumCost;
        }

        public override string ToString()
        {
            return base.ToString() + "(sum cost = " + SumCost + ")";
        }
    }
}
