namespace Vector.Data
{
    public class Application
    {
        public int Id { get; set; }
        public string Company { get; set; } = string.Empty;
        public string JobTitle { get; set; } = string.Empty;
        public string? JobUrl { get; set; }
        public string? JobDescription { get; set; }
        public string? Location { get; set; }
        public string? Salary { get; set; }
        public string? Source { get; set; }
        public int ApplicationStatusId { get; set; }
        public DateTime? DateApplied { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string? Notes { get; set; }

        public ApplicationStatus Status { get; set; } = null!;
        public ICollection<ApplicationActivity> ApplicationActivity = [];
    }
}
