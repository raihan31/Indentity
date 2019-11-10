namespace Repository.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public Group Group { get; set; }
        public Person Person { get; set; }
        public int GroupId { get; set; }
    }
}