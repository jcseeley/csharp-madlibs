using Microsoft.AspNetCore.Mvc;
using Madlibs.Models;

namespace Madlibs.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
      public ActionResult Home() { return View(); }


    [Route("/form")]
      public ActionResult Form() { return View(); }


    [Route("/form-two")]
      public ActionResult FormTwo() { return View(); }


    [Route("/result-one")]
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

    [Route("/result-two")]
    public ActionResult MadLibTwo(string inputOne, string inputTwo, string inputThree, string inputFour, string inputFive, string inputSix, string inputSeven, string inputEight, string inputNine)
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
