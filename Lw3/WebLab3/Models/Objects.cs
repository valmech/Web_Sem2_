namespace WebLab3.Models
{
    public class Objects
    {
        public int Id { get; set; }
        public string Address { get; set; } = string.Empty;
        public decimal Area { get; set; }
        public decimal Price { get; set; }
        public int Rooms { get; set; }
        public int Floor { get; set; }
        public string Condition { get; set; } = string.Empty;
        public int TypeHouseId { get; set; }
        public TypeHouses? TypeHouse { get; set; }
    }
}
