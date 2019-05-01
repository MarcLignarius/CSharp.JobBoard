using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;

namespace JobBoard.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Index()
    {
        JobPosting firstPost = new JobPosting("Add first job to the Job Board", "", "");
        return View(firstPost);
    }

    [Route("/jobpostings/new")]
    public ActionResult JobForm()
    {
        return View();
    }

    [Route("/jobpostings")]
    public ActionResult Create(string title, string description, string contact)
    {
        JobPosting myJobPosting = new JobPosting(title, description, contact);
        return View("Index", myJobPosting);
    }

  }
}
