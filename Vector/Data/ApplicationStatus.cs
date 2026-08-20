namespace Vector.Data
{
    public class ApplicationStatus
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int SortOrder { get; set; }
        public ICollection<Application> Applications { get; set; } = [];
    }
}
