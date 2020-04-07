using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeTrainingApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HomeTrainingApp.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            var rvm = new RegisterViewModel();
            return View();
        }
    }
}