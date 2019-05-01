using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;
using System.Collections.Generic;

namespace JobBoard.Controllers
{
  public class JobPostingController : Controller
  {

    [Route("/jobpostings")]
    public ActionResult Index()
    {
        List<JobPosting> allJobs = JobPosting.GetAll();
        return View(allJobs);
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
        return RedirectToAction("Index");
    }

  }
}
