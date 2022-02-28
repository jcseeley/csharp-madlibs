using Microsoft.AspNetCore.Mvc;
using Madlibs.Models;

namespace Madlibs.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Form() { return View(); }

    [Route("/result")]
    public ActionResult Madlib(string inputOne, string inputTwo, string inputThree, string inputFour, string inputFive, string inputSix, string inputSeven, string inputEight, string inputNine)
    {
      UserInput myInput = new UserInput();
      myInput.InputOne = inputOne;
      myInput.InputTwo = inputTwo;
      myInput.InputThree = inputThree;
      myInput.InputFour = inputFour;
      myInput.InputFive = inputFive;
      myInput.InputSix = inputSix;
      myInput.InputSeven = inputSeven;
      myInput.InputEight = inputEight;
      myInput.InputNine = inputNine;
      return View(myInput);
    }
  }
}
