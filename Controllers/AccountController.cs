using Demo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Demo.Controllers
{
    
    public class AccountController : Controller
    {

        private readonly DemoContext _demoContext;

        public AccountController(DemoContext demoContext)
        {
            _demoContext = demoContext;

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterModel registerModel)
        {
            
                if (ModelState.IsValid)
                {
                    var check = _demoContext.Register.FirstOrDefault(s => s.UserEmail == registerModel.UserEmail);
                    if (check == null)
                    {
                        registerModel.Password = registerModel.Password;
                   
                        _demoContext.Register.Add(registerModel);
                        _demoContext.SaveChanges();
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ViewBag.error = "Email already exists";
                        return View();
                    }


                }
                return View();


            
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(string email, string password)
        {
            if (ModelState.IsValid)
            {


                var f_password = password;
                var data = _demoContext.Register.Where(s => s.UserEmail.Equals(email) && s.Password.Equals(password)).ToList();
                if (data.Count() > 0)
                {

                    ViewData["message"] = "Successfully Logged In";
                    return RedirectToAction("Index","Home", null);


                }
                else
                {
                    ViewData["message"] = "Login Failed";
                    return RedirectToAction("Login","Account", null);
                }
            }
            return View();
        }

       

    }
}
