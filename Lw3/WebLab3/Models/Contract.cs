namespace WebLab3.Models
{
    public class Contract
    {
        public int Id { get; set; }
        public DateTime DealDate { get; set; }
        public int ObjectId { get; set; }
        public int EmployeeId { get; set; }
        public int ClientId { get; set; }
        public decimal DealAmount { get; set; }
        public decimal CommissionAmount { get; set; }
        public string City { get; set; } = string.Empty;
        public Objects? Object { get; set; }
        public Employee? Employee { get; set; }
        public Clients? Client { get; set; }

    }
}
