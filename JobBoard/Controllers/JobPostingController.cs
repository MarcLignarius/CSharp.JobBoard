using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using JobBoard.Models;

namespace JobBoard.Controllers
{
  public class JobPostingController : Controller
  {

    [HttpGet("/jobpostings")]
    public ActionResult Index()
    {
        List<JobPosting> allJobs = JobPosting.GetAll();
        return View(allJobs);
    }

    [HttpGet("/jobpostings/new")]
    public ActionResult JobForm()
    {
        return View();
    }

    [HttpPost("/jobpostings")]
    public ActionResult Create(string title, string description, string contact)
    {
        JobPosting myJobPosting = new JobPosting(title, description, contact);
        return RedirectToAction("Index");
    }

  }
}
