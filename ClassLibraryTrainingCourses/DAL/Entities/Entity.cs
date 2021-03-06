namespace ClassLibraryTrainingCourses.DAL.Entities
{
    public class Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Entity() { }

        public Entity (int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
