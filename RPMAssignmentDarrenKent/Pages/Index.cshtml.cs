using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RPMAssignmentDarrenKent.Pages
{
  public class IndexModel : PageModel
  {
    [BindProperty]
    public string txtInput { get; set; }
    [BindProperty]
    public string txtOutput { get; set; } //= "";

    public void OnGet()
    {
    }

    public void OnPost()
    {
      var morningStart = new TimeSpan(0, 0, 0); //6am
      var morningEnd = new TimeSpan(11, 59, 59);

      var afternoonStart = new TimeSpan(12, 0, 0); //Noon
      var afternoonEnd = new TimeSpan(17, 59, 59);

      var eveningStart = new TimeSpan(18, 0, 0); //6pm
      var eveningEnd = new TimeSpan(23, 59, 59);

      //Use this for testing.
      //var now = DateTime.Now.AddHours(12).TimeOfDay;
      var now = DateTime.Now.TimeOfDay;

      if ((now > morningStart) && (now < morningEnd))
      {
        var message = "Good Morning, this is your text: ";
        txtOutput = message += txtInput;
      }
      else if ((now > afternoonStart) && (now < afternoonEnd))
      {
        var message = "Good Afternoon, this is your text: ";
        txtOutput = message += txtInput;
      }
      else if ((now > eveningStart) && (now < eveningEnd))
      {
        var message = "Good Evening, this is your text: ";
        txtOutput = message += txtInput;
      }
      else
      {
        var message = "Something went wrong, this is your text: ";
        txtOutput = message += txtInput;
      }
    }

  }
}
