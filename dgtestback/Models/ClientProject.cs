using dgtestback.Enums;

namespace dgtestback.Models
{
    public class ClientProject: User
    {
        public ClientProject()
        {
            ProjectStatuses = new List<ProjectStatus>();
        }
        public string Name { get; set; }
        public string? Company { get; set; }
        public string? Email { get; set; }
        public string Url { get; set; }
        public bool Active { get; set; }
        public TrafficStatus? TrafficStatus { get; set; }
        public bool IsUpdatedRequested { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public List<ProjectStatus> ProjectStatuses { get; set; }
    }
}
