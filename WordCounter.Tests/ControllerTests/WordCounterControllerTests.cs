using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordCounterControllerTest
    {
      [TestMethod]
      public void Index_ReturnsCorrectView_True()
      {
        WordCounterController controller = new WordCounterController();
        ActionResult indexView = controller.Index();
        Assert.IsInstanceOfType(indexView, typeof(ViewResult));
      }
      [TestMethod]
      public void CreateCount_ReturnsCorrectView_True()
      {
        WordCounterController controller = new WordCounterController();
        ActionResult indexView = controller.CreateCount();
        Assert.IsInstanceOfType(indexView, typeof(ViewResult));
      }
      [TestMethod]
      public void Create_ReturnsCorrectView_True()
      {
        WordCounterController controller = new WordCounterController();
        ActionResult indexView = controller.Create("test", "test");
        Assert.IsInstanceOfType(indexView, typeof(ViewResult));
      }


      [TestMethod]
      public void Create_HasCorrectModelType_RepeatCounter()
      {
        ViewResult indexView = new WordCounterController().Create("index", "index") as ViewResult;
        var result = indexView.ViewData.Model;
        Assert.IsInstanceOfType(result, typeof(RepeatCounter));
      }


    }
}
