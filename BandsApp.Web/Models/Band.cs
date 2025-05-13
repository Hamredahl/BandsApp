namespace BandsApp.Web.Models
{
    public class Band
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public List<String> Albums { get; set; }
        public string YouTubeUrl { get; set; }
    }
}
