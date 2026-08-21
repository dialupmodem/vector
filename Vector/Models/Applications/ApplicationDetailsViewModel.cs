namespace Vector.Models.Applications
{
    public class ApplicationDetailsViewModel
    {
        public int Id { get; set; }
        public string Company { get; set; } = "";
        public string JobTitle { get; set; } = "";
        public string Status { get; set; } = "";
        public DateTime? DateApplied { get; set; }
        public string? JobDescription { get; set; }
        public string? JobLocation { get; set; }
        public string? JobSalary { get; set; }
        public string? JobSource { get; set; }
        public string? JobUrl { get; set; }
        public string? Notes { get; set; }

        public List<ApplicationActivityListItemModel> Activity { get; set; } = [];
    }
}
