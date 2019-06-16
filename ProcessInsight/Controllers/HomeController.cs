using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProcessInsight.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var processes = System.Diagnostics.Process.GetProcesses();

            var processNames = processes.Select(p => p.ProcessName);

            return View(processNames);
        }
    }
}
