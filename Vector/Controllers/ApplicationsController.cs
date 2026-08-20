using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
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
                .Select(a => new ApplicationsListItemViewModel
                {
                    Id = a.Id,
                    Company = a.Company ?? "",
                    JobTitle = a.JobTitle ?? "",
                    ApplicationStatus = a.Status ?? "",
                    DateApplied = a.DateApplied
                })
                .ToListAsync();

            var model = new ApplicationListViewModel() { 
                Applications = applications 
            };

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View(new CreateApplicationViewModel
            {
                DateApplied = DateTime.Today
            });
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateApplicationViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var application = new Application
            {
                Company = model.Company,
                JobTitle = model.JobTitle,
                Status = model.Status,
                DateApplied = model.DateApplied,
                JobUrl = model.JobUrl,
                Notes = model.Notes
            };

            _context.Applications.Add(application);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
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
