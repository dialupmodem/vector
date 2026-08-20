namespace Vector.Models.Applications
{
    public class CreateApplicationViewModel
    {
        public string Company { get; set; } = "";
        public string JobTitle { get; set; } = "";
        public string Status { get; set; } = "";
        public DateTime? DateApplied { get; set; }
        public string? JobUrl { get; set; }
        public string? Notes { get; set; }
    }
}
