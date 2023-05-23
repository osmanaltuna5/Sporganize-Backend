namespace Sporganize.Models
{
    public class Province
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<District> Districts { get; set; }

    }

}
