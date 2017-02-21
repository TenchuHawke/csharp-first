using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace passcode.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            int count=0;
            ViewBag.count=count;
            return View ("home");
        }
                // GET: /Home/
        [HttpPost]
        [Route("")]
        public IActionResult GeneratePasscode(int count)
        {
            count++;
            ViewBag.count=count;
            String passcode="";
            Random rand = new Random();
            char character = Convert.ToChar(10);
            int code=0;
            for (int i = 0; i < 15; i++)
            {
                while (code<48 || (code > 57 && code < 65)){
                    code = rand.Next(48,90);
                    character = Convert.ToChar(code);
                    System.Console.WriteLine(character.ToString());
                }
                passcode=passcode+character.ToString();
                code=0;
            }
            System.Console.WriteLine(passcode);
            ViewBag.passcode=passcode;
            return View("Index");
        }
    }
}
