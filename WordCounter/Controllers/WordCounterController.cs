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
      public ActionResult Create(string word, string sentence)
      {
        RepeatCounter newCount = new RepeatCounter(word, sentence);
        return View("Index", newCount);
      }

    }
}
