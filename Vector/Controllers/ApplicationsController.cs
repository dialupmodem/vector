using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vector.Data;
using Vector.Models.Applications;

namespace Vector.Controllers
{
    public class ApplicationsController : Controller
    {
        private readonly ApplicationDbContext _context;
        
        public ApplicationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var applications = await _context.Applications
                .Select(a => new ApplicationsListViewModel
                {
                    Id = a.Id,
                    Company = a.Company ?? "",
                    JobTitle = a.JobTitle ?? "",
                    ApplicationStatus = a.Status ?? "",
                    DateApplied = a.DateApplied
                })
                .ToListAsync();

            return View(applications);
        }
        public async Task<IActionResult> Create()
        {
            return Ok();
        }
        public async Task<IActionResult> Edit()
        {
            return Ok();
        }
        public async Task<IActionResult> Details()
        {
            return Ok();
        }
    }
}
