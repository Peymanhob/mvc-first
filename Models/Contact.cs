namespace mvc_first.Models
{
    public class Contact
    {
        [required]
        public int Id { get; set; }
      
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public Contact(int Id, string Name, string Email, string Phone)
        {
            Id = Id;
            Name = Name;
            Email = Email;
            Phone = Phone;
        }
    }
}
