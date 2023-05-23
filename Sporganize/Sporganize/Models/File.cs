namespace Sporganize.Models
{
    public class File
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Extension { get; set; }
        public string Type { get; set; }
        public byte[] Content { get; set; }
        public User? User { get; set; }
        public Team? Team { get; set; }

    }

}
