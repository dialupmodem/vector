namespace Vector.Models.Applications
{
    public class ApplicationsListViewModel
    {
        public int Id { get; set; }
        public string Company { get; set; } = "";
        public string JobTitle { get; set; } = "";
        public string ApplicationStatus { get; set; } = "";
        public DateTime? DateApplied { get; set; }

    }
}
