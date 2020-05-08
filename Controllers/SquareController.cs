using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NumbersAndSquareRoot.Controllers
{
    public class SquareController : Controller
    {
        [HttpGet]
        public IActionResult Sqrt()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Sqrt(string firstNumber, string secondNumber)
        {
            int numberOne = int.Parse(firstNumber);
            int numberTwo = int.Parse(secondNumber);
            double result = Math.Sqrt(numberOne);
            double result2 = Math.Sqrt(numberTwo);
            ViewBag.result = result;
            ViewBag.result2 = result2;
            ViewBag.numberOne = firstNumber;
            ViewBag.numberTwo = secondNumber;

            return View();
        }
    }
}