using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Home.models;
using Microsoft.AspNetCore.Mvc;

namespace validateForm.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPostAttribute]
        [Route("CreateUser")]
        public IActionResult CreateUser(User NewUser)
        {
            var errors = ModelState.Select(x => x.Value.Errors)
                .Where(y => y.Count > 0)
                .ToList();
            ViewBag.errors = errors;
            ViewBag.Name = NewUser.FirstName;
            if (ViewBag.errors.Count == 0)
                {
                return View("Success");
                }   
            else {
                return View("User");
            }
        
        }
    }
}
