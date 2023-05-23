namespace Sporganize.Models
{
    public class District
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ProvinceId { get; set; }
        public Province? Province { get; set;}
        public ICollection<Street> Streets { get; set; }

    }

}
