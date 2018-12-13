using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RavenDB_Embedded.Controllers
{
    public class SignalrController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}