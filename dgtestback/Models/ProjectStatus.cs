namespace dgtestback.Models
{
    public class ProjectStatus
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string?  Message { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
