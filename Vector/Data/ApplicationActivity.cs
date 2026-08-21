namespace Vector.Data
{
    public class ApplicationActivity
    {
        public int Id { get; set; }
        public int ApplicationId { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }

        public Application Application { get; set; } = null!;
    }
}
