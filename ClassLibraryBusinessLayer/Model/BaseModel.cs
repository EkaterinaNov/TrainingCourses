namespace ClassLibraryBusinessLayer.Model
{
    public class BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public BaseModel() { }

        public BaseModel(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
