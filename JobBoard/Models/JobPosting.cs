using System.Collections.Generic;

namespace JobBoard.Models
{
  public class JobPosting
  {
    private string _title;
    private string _description;
    private string _contact;

    private static List<JobPosting> _instances = new List<JobPosting> {};

    public string Title { get => _title; set => _title = value; }
    public string Description { get => _description; set => _description = value; }
    public string Contact { get => _contact; set => _contact = value; }

    public JobPosting(string title, string description, string contact)
    {
      _title = title;
      _description = description;
      _contact = contact;
      _instances.Add(this);
    }

    public static List<JobPosting> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}
