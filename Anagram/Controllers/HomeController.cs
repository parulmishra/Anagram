using Microsoft.AspNetCore.Mvc;
using Anagram.Models;
using System.Collections.Generic;
using System;

namespace Anagram.Controllers
{
  public class HomeController : Controller
  {


    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
    [HttpPost("/find")]
    public ActionResult Find()
    {
      AnagramClass.ClearAll();
      AnagramClass newAnagram = new AnagramClass(Request.Form["word1"], Request.Form["word2"]);
      return View(newAnagram);
    }
  }

}
