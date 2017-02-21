using System;
using System.Collections.Generic;
using dapperProj.Models;
using Microsoft.AspNetCore.Mvc;
using dapperProj.Factory; //Need to include reference to new Factory Namespace
using Microsoft.AspNetCore.Identity;
//Other using statements
namespace dapperProj.Controllers
{
    public class YourController : Controller
    {
        //Route
        public IActionResult Method(User user)
        {
            if(ModelState.IsValid)
            {
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                user.Password = Hasher.HashPassword(user, user.Password);
                //Save your user object to the database
            }
        }
    }
}
    public class HomeController : Controller
    {
        // Inside our HomeController class
        private readonly UserFactory userFactory;
        //use dependency injection on the HomeController constructor to get a UserFactory object
        public HomeController(UserFactory user)
        {
            userFactory = user;
        }
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            //We can call upon the methods of the userFactory directly now.
            ViewBag.Users = userFactory.FindAll();
            return View();
        }
    }
}