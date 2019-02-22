using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
    public class WordCounterController : Controller
    {

      [HttpGet("/count")]
      public ActionResult Index()
      {
        return View();
      }

      [HttpGet("/count/new")]
      public ActionResult CreateCount()
      {
        return View();
      }

      [HttpPost("/count")]
      public ActionResult Create(string w, string s)
      {
        RepeatCounter newCount = new RepeatCounter(w, s);
        return View("Index", newCount);
      }

    }
}
