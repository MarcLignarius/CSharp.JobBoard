using Microsoft.AspNetCore.Mvc;

namespace JobPosting.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}
