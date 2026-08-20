namespace Vector.Data
{
    public class Application
    {
        public int Id { get; set; }
        public string Company { get; set; } = string.Empty;
        public string JobTitle { get; set; } = string.Empty;
        public string? JobUrl { get; set; }
        public int ApplicationStatusId { get; set; }
        public ApplicationStatus Status { get; set; } = null!;
        public DateTime? DateApplied { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string? Notes { get; set; }
    }
}
