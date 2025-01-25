using Activity_Tracker.Models;
using Microsoft.AspNetCore.Mvc;

namespace Activity_Tracker.Controllers
{
    public class ActivityController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ActivityController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Activities.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Create([Bind("Id,Name,desc,completed")] Activity activity)
        {
            if (ModelState.IsValid)
            {   
                _db.Add(activity);
                _db.SaveChanges();
                return RedirectToAction("Index");
            } else
            {
                return View("Index");
            }
        }
    }
}
