namespace WebLab3.Models
{
    public class Clients
    {
        public int Id { get; set; }
        public string LastName { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string ClientType { get; set; } = string.Empty;
    }
}
