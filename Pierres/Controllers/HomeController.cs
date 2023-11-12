using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Pierres.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace Pierres.Controllers;

    public class HomeController : Controller
 {
        private readonly PierresContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(UserManager<ApplicationUser> userManager, PierresContext db)
        {
            _userManager = userManager;
            _db = db;
        }

        [HttpGet("/")]
        public async Task<ActionResult> Index()
        {
            Treat[] treats = _db.Treats.ToArray();
            Flavor[] flavors = _db.Flavors.ToArray();
            Dictionary<string, object[]> model = new Dictionary<string, object[]>();
            model.Add("treats", treats);
            model.Add("flavors", flavors);
            string userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            ApplicationUser currentUser = await _userManager.FindByIdAsync(userId);
            return View(model);
        }
    }