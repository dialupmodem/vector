using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.AspNetCore.Mvc.Rendering;
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
                    Company = a.Company,
                    JobTitle = a.JobTitle,
                    ApplicationStatus = a.Status.Name,
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
                DateApplied = DateTime.Today,
                StatusOptions = await GetStatusOptionsAsync()
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
                ApplicationStatusId = model.ApplicationStatusId,
                DateApplied = model.DateApplied,
                JobUrl = model.JobUrl,
                Notes = model.Notes
            };

            _context.Applications.Add(application);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var model = await _context.Applications
                .AsNoTracking()
                .Where(a => a.Id == id)
                .Select(a => new EditApplicationViewModel
                {
                    Id = a.Id,
                    Company = a.Company,
                    JobTitle = a.JobTitle,
                    ApplicationStatusId = a.ApplicationStatusId,
                    DateApplied = a.DateApplied,
                    JobUrl = a.JobUrl,
                    Notes = a.Notes
                })
                .SingleOrDefaultAsync();

            if (model is null)
                return NotFound();

            model.StatusOptions = await GetStatusOptionsAsync();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditApplicationViewModel model)
        {
            if (id != model.Id)
                return BadRequest();

            if (!ModelState.IsValid)
                return View(model);

            var application = await _context.Applications.FindAsync(id);

            if (application is null)
                return NotFound();

            application.Company = model.Company;
            application.JobTitle = model.JobTitle;
            application.ApplicationStatusId = model.ApplicationStatusId;
            application.DateApplied = model.DateApplied;
            application.JobUrl = model.JobUrl;
            application.Notes = model.Notes;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var model = await _context.Applications
                .AsNoTracking()
                .Where(a => a.Id == id)
                .Select(a => new ApplicationDetailsViewModel
                {
                    Id = a.Id,
                    Company = a.Company,
                    JobTitle = a.JobTitle,
                    Status = a.Status.Name,
                    DateApplied = a.DateApplied,
                    JobUrl = a.JobUrl,
                    Notes = a.Notes
                })
                .SingleOrDefaultAsync();

            if (model is null)
                return NotFound();

           

            return View(model);
        }
        
        private async Task<List<SelectListItem>> GetStatusOptionsAsync()
        {
            return await _context.ApplicationStatus
                .AsNoTracking()
                .OrderBy(s => s.SortOrder)
                .Select(s => new SelectListItem
                {
                    Value = s.Id.ToString(),
                    Text = s.Name
                })
                .ToListAsync();
        }
    }
}
