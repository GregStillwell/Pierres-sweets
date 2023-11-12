using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pierres.Models;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;

namespace Pierres.Controllers
{
  public class HomeController : Controller
  {
    private readonly PierresContext _db;
    
    public HomeController(PierresContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      Flavor[] flavors = _db.Flavors.ToArray();
      Treat[] treats = _db.Treats.ToArray();
      Dictionary<string,object[]> model = new Dictionary<string,object[]>();
      model.Add("flavors", flavors);
      model.Add("treats", treats);
      return View(model);
    }
  }
}