using Microsoft.AspNetCore.Mvc;
using Madlibs.Models;

namespace Madlibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Form() { return View(); }

    // Press submit -> form action takes us to /result (with the form arguments)
    [Route("/result")]
    public ActionResult Display(string input1, string input2, string input3)
    {
    MadlibsVariable myMadlib = new MadlibsVariable();
    myMadlib.Input1 =  input1; 
    myMadlib.Input2 = input2;
    myMadlib.Input3 = input3;
    return View(myMadlib);
    }

    //Make a new form with the submit going to /puppy <= eventually figure out a way to change the action of the form

// a button on "/" takes us to the puppy page. 
    [Route("/puppy")]
    public ActionResult Puppy(string input1, string input2, string input3) 
    { 
      
      return View(); 
    
    }


  }
}