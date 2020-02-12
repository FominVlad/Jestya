namespace AuthApp.Models
{
    public class Role
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public string RoleName { get; set; }

        public Group Group { get; set; }
    }
}
