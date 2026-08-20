namespace Vector.Data
{
    public class Application
    {
        public int Id { get; set; }
        public string Company { get; set; } = string.Empty;
        public string JobTitle { get; set; } = string.Empty;
        public string? JobUrl { get; set; }
        public string Status { get; set; } = string.Empty;
        public DateTime? DateApplied { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string? Notes { get; set; }
    }
}
