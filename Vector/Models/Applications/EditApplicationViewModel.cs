using Microsoft.AspNetCore.Mvc.Rendering;

namespace Vector.Models.Applications
{
    public class EditApplicationViewModel
    {
        public int Id { get; set; }
        public string Company { get; set; } = "";
        public string JobTitle { get; set; } = "";
        public int ApplicationStatusId { get; set; }
        public IEnumerable<SelectListItem> StatusOptions { get; set; } = [];
        public DateTime? DateApplied { get; set; }
        public string? JobUrl { get; set; }
        public string? Notes { get; set; }
    }
}
