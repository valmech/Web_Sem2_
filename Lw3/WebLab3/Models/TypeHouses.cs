namespace WebLab3.Models
{
    public class TypeHouses
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<Objects> Objects { get; set; } = new List<Objects>();
    }
}
