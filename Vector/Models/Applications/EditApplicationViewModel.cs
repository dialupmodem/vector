namespace Vector.Models.Applications
{
    public class EditApplicationViewModel
    {
        public int Id { get; set; }
        public string Company { get; set; } = "";
        public string JobTitle { get; set; } = "";
        public string Status { get; set; } = "";
        public DateTime? DateApplied { get; set; }
        public string? JobUrl { get; set; }
        public string? Notes { get; set; }
    }
}
