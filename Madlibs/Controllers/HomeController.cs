using Microsoft.AspNetCore.Mvc;
using Madlibs.Models;

namespace Madlibs.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Form() { return View(); }

    [Route("/result")]
    public ActionResult Madlib(string inputOne, string inputTwo, string inputThree, string inputFour)
    {
      UserInput myInput = new UserInput();
      myInput.InputOne = inputOne;
      myInput.InputTwo = inputTwo;
      myInput.InputThree = inputThree;
      myInput.InputFour = inputFour;
      return View(myInput);
    }
  }
}
