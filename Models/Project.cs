namespace mvc_first.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string img { get; set; }

        public Project(int id, string name, string description, string img)
        {
            Id = id;
            Name = name;
            Description = description;
            this.img = img;
        }
    }
}
